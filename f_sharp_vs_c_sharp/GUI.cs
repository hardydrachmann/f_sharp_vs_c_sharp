using Logic_cSharp;
using Logic_fSharp;
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
        private Flogic fLogic;

        public GUI()
        {
            InitializeComponent();
            InitializeLogicClasses();
        }

        private void InitializeLogicClasses()
        {
            cLogic = new Clogic();
            fLogic = new Flogic();

            if (cLogic != null && fLogic != null)
            {
                lbl_cLogic.Text = "C# logic class instantiated!";
                lbl_fLogic.Text = "F# logic class instantiated!";
            }
        }

    }
}
