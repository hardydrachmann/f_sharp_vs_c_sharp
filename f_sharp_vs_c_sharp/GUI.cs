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
        Random random = new Random();

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
            Stopwatch timer = new Stopwatch();

            List<int> lst = new List<int>();
            lst = GenerateRandomList(Int32.Parse(tbListLength.Text));
            FSharpList<int> fsList = ListModule.OfSeq(lst);
            Console.WriteLine("Not Sorted");
            foreach (var item in fsList)
            {
                Console.WriteLine(item);
            }

            timer.Start();
            FLogic.quicksort(fsList);
            timer.Stop();
            lblSortingF.Text = timer.ElapsedMilliseconds.ToString() + " ms";
            Console.WriteLine("Sorted");
            foreach (var item in FLogic.quicksort(fsList))
            {
                Console.WriteLine(item);
            }


        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            List<int> csList = new List<int>();
            for (int i = 0; i < 10000 ; i++)
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


        private int GenerateRandomNumbers()
        {
            int r = random.Next(0, 1000);
            return r;
        }

        private List<int> GenerateRandomList(int listLength)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < listLength; i++)
            {
                myList.Add(GenerateRandomNumbers());
            }
            return myList;
        }
    }
}
