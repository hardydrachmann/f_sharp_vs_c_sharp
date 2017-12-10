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
        private Clogic cLogic;

        public GUI()
        {
            InitializeComponent();
            cLogic = new Clogic();
        }

        // Logic functionality.
        private void btnSort_Click(object sender, EventArgs e)
        {
            FSharpList<int> list = generateCompatibleList();

            startTime();
            FLogic.quicksort(list);
            lblSortingF.Text = timeElapsed();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            FSharpList<int> list = generateCompatibleList();

            startTime();
            FLogic.reverse(list);
            lblReverseF.Text = timeElapsed();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FSharpList<int> list = generateCompatibleList();

            startTime();
            //FLogic.calculate(list);
            lblReverseF.Text = timeElapsed();
        }


        // Exit application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Helper methods.
        private FSharpList<int> generateCompatibleList()
        {
            int length = int.Parse(tbListLength.Text);
            Random random = new Random();
            List<int> csList = new List<int>();
            for (int i = 0; i < length; i++)
                csList.Add(random.Next(100));

            return ListModule.OfSeq(csList);
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
