using Entidades.Capas.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.Interfaces
{
    public partial class Form1 : Form
    {
        clsLnEntidades Data = new clsLnEntidades();
        clsBeEntidades entidad = new clsBeEntidades();
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }
        int N = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            label2.Text = N.ToString();
            progressBar1.Value = N;

            if (N == 100)
            {
                this.Hide();
                timer1.Stop();


                //FrmLogin login = new FrmLogin();
                //login.Show();

                PrimeraVez();
            }

              void PrimeraVez ()
            {



                if ((dt.Rows.Count == 2))
                {




                }
                else
                {
                    FrmLogin login = new FrmLogin();
                    login.Show();
                }
                 
               // if ((dt.Rows.Count == 0))
               // {
                    //FrmNuevo nuevo = new FrmNuevo();
                   // nuevo.Show();

               // }

                }

                


            }

           
        }
    }

