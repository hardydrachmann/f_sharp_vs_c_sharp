using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


    static class Program
    {       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());

        // Instantiate logic classes
        initLogic();
    }

    private static void initLogic()
    {
        Logic_Csharp cLogic = new Logic_Csharp();
        Logic_Fsharp fLogic = new Logic_Fsharp();
    }
}