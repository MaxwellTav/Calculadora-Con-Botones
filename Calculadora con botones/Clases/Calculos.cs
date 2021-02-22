using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Calculadora_con_botones.Clases
{
    class Calculos
    {
        #region Variables
        //De operacion
        public double Convert1, Convert2;
        double OperationResult;

        public string QueEstaHaciendo;
        public double Res;

        //Index IndexForm = new Index();
        #endregion

        public void ManualCalculos()
        {
            MessageBox.Show("Está utilizando el modo manual, siga las instrucciones para continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
            string numero1 = Interaction.InputBox("Digite el primer número", "Número 1","0");

            string operacion = Interaction.InputBox("1) Digite \"+\"" + " para sumar\n" + 
                                                    "2) Digite \"-\"" + " para restar\n" +
                                                    "3) Digite \"x\"" + " para Multiplicar\n" +
                                                    "4) Digite \"/\"" + " para restar\n" , 
                                                    "Operación a realizar", "+");
            
            string numero2 = Interaction.InputBox("Digite el primer número", "Número 1", "0");

            DialogResult question = MessageBox.Show("¿Esta operación es correcta?\n" + "Resultado:\n" + numero1 + " " + operacion + " " +  numero2 + " = ?", "Confirme operación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (question == DialogResult.Yes)
            {
                //hacer la oepracion
                try
                {
                    Convert1 = Int32.Parse(numero1);
                    Convert2 = Int32.Parse(numero2);

                    switch (operacion)
                    {
                            //suma
                        case "+":
                            OperationResult = Convert1 + Convert2;
                            break;
                        case "1":
                            OperationResult = Convert1 + Convert2;
                            break;

                        //resta
                        case "-":
                            OperationResult = Convert1 - Convert2;
                            break;
                        case "2":
                            OperationResult = Convert1 + Convert2;
                            break;

                        //multiplicación
                        case "*":
                            OperationResult = Convert1 * Convert2;
                            break;
                        case "x":
                            OperationResult = Convert1 * Convert2;
                            break;
                        case "X":
                            OperationResult = Convert1 * Convert2;
                            break;
                        case "3":
                            OperationResult = Convert1 + Convert2;
                            break;

                        //division
                        case "/":
                            OperationResult = Convert1 / Convert2;
                            break;
                        case "4":
                            OperationResult = Convert1 + Convert2;
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Hubo un error en la operación" + "\nDescipción del error:\n" + err, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Fin de hacer la operacion


                MessageBox.Show("Resultado:\n" + numero1 + " " + operacion + " " + numero2 + " = " + OperationResult);
                DialogResult question2 = MessageBox.Show("¿Desea repetir el proceso?", "Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question2 == DialogResult.Yes)
                {
                    ManualCalculos();
                }
            }
            if (question == DialogResult.No)
            {
                ManualCalculos();
            }
            if (question == DialogResult.Cancel)
            {
                MessageBox.Show("Acción cancelada", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public double Calcular(double Cal1, double Cal2)
        {
            switch(QueEstaHaciendo)
            {
                case "s":
                    //IndexForm.Indicador.Text = "+";
                    Res = Cal1 + Cal2;
                    break;
                case "r":
                    //IndexForm.Indicador.Text = "-";
                    Res = Cal1 - Cal2;
                    break;
                case "m":
                    //IndexForm.Indicador.Text = "x";
                    Res = Cal1 * Cal2;
                    break;
                case "d":
                    //IndexForm.Indicador.Text = "÷";
                    Res = Cal1 / Cal2;
                    break;
            }
            return Res;
        }
    }
}
