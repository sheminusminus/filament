using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilamentFinalProject
{
    //public class Creation
    //{
    //}

    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            bool done = false;

            while (!done)
            {
                Application.DoEvents();

                // Check if any forms are visible.
                bool anyVisible = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Visible)
                        anyVisible = true;
                }

                // If no forms were visible, then quit.
                if (!anyVisible)
                    done = true;
            }
        }

    }

}
