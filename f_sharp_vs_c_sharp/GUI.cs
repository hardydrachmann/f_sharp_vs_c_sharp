using Logic_cSharp;
using FSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitializeLogicClasses();
        }

        private void InitializeLogicClasses()
        {
            cLogic = new Clogic();
        }

        
        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            List<int> csList = new List<int>();
            for (int i = 0; i < 100 ; i++)
            {
                csList.Add(i);
            }
            timer.Start();
            FSharpList<int> fsList = ListModule.OfSeq(csList);
            FLogic.reverse(fsList);
            timer.Stop();
            lblReverceF.Text = timer.ElapsedMilliseconds.ToString() + " ms";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
        



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
