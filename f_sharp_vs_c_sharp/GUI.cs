using Logic_cSharp;
using FSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.FSharp.Collections;
using System.Diagnostics;

namespace f_sharp_vs_c_sharp
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        // Logic functionality.
        private void btnSort_Click(object sender, EventArgs e)
        {  
            startTime();
            FLogic.quicksort(FSList());
            lblSortingF.Text = timeElapsed();

            startTime();
            Clogic.Sort(CSList());
            lblSortingC.Text = timeElapsed();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            startTime();
            FLogic.reverse(FSList());
            lblReverseF.Text = timeElapsed();

            startTime();
            Clogic.Reverse(CSList());
            lblReverseC.Text = timeElapsed();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            startTime();
            //FLogic.calculate(FSList());
            lblCalculateF.Text = timeElapsed();

            startTime();
            //CLogic.calculate(CSList());
            lblCalculateC.Text = timeElapsed();
        }


        // Exit application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Helper methods.
        private FSharpList<int> FSList()
        {
            return (FSharpList<int>)generateCompatibleList(true);
        }

        private List<int> CSList()
        {
            return (List<int>)generateCompatibleList(false);
        }

        private IEnumerable<int> generateCompatibleList(bool fs)
        {
            int length = int.Parse(tbListLength.Text);
            Random random = new Random();
            List<int> csList = new List<int>();
            for (int i = 0; i < length; i++)
                csList.Add(random.Next(100));

            if (fs)
                return ListModule.OfSeq(csList);
            else return csList;
        }

        // Timer
        private Stopwatch timer = new Stopwatch();
        private void startTime()
        {
            timer.Start();
        }

        private string timeElapsed()
        {
            timer.Stop();
            long elapsed = timer.ElapsedMilliseconds;
            timer.Reset();
            return elapsed.ToString() + " ms";
        }
    }
}
