using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.Interfaces
{
    public static class Program
    {
        public static string stringUserName;
        public static string stringUserPassword;
        public static bool   boolUserAuthenticated;



        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            while (true)
            {
                Application.Run(new FrmLogin());

                if (boolUserAuthenticated)
                {
                    Application.Run(new FrmMDIPrincipal());
                }

                else {
                    break;
                }
            
            
            
            }

        }
            

      }
    }

