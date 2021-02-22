using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_con_botones
{
    public partial class Index : Form
    {
        //variables
        Clases.AppSettings _AppSettings = new Clases.AppSettings();
        Clases.Calculos _Calculos = new Clases.Calculos();

        double primero, segundo;

        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            GetComponentsEvent();
        }

        public void GetComponentsEvent()
        {
            Index FormIndex = new Index();
            TitleApp.Text = FormIndex.Text;
            PanelText.Text = "0";

            CambiarColorAlAzar();
        }

        public void CambiarColorAlAzar()
        {
            //cambiar color al azar
            int r, g, b;
            Random rnd = new Random();
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            panel1.BackColor = Color.FromArgb(r, g, b);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            _AppSettings.SalirDeLaAplicacion();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //DetalleDe0();
            PanelText.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetalleDe0(); 
            PanelText.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text += 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DetalleDe0();
            PanelText.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (PanelText.Text.Length <= 1)
                {
                    PanelText.Text = "0";
                }
                else
                {
                    PanelText.Text = PanelText.Text.Substring(0, PanelText.Text.Count() - 1);
                }
            }
            catch(Exception err)
            {
                PanelText.Text = "0";
                Console.WriteLine("Exception 0x7092001\nError: " + err);
            }
        }

        void DetalleDe0()
        {
            if (PanelText.Text == "0")
            {
                PanelText.Text = "";
            }
        }

        //igual
        private void button13_Click(object sender, EventArgs e)
        {
            Indicador.Text = "NA";
            segundo = double.Parse(PanelText.Text);
            _Calculos.Calcular(primero, segundo);
            PanelText.Text = _Calculos.Res.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Indicador.Text = "+";
            _Calculos.QueEstaHaciendo = "s";
            primero = double.Parse(PanelText.Text);
            PanelText.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Indicador.Text = "-";
            _Calculos.QueEstaHaciendo = "r";
            primero = double.Parse(PanelText.Text);
            PanelText.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Indicador.Text = "x";
            _Calculos.QueEstaHaciendo = "m";
            primero = double.Parse(PanelText.Text);
            PanelText.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Indicador.Text = "÷";
            _Calculos.QueEstaHaciendo = "d";
            primero = double.Parse(PanelText.Text);
            PanelText.Text = "0";
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            CambiarColorAlAzar();
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            _Calculos.ManualCalculos();
        }
    }
}
