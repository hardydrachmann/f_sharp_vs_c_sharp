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
            int x = 10;
           FLogic.Reverse(10);
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
