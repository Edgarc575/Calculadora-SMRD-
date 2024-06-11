using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Sencilla_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        //Se crea una clase publica para las variables globales
        public static class VGlobal
        {
            public static double num1; //Numero 1 tipo doble 
            public static double num2; //Numero 2 tipo doble
            public static double resultado=0; //Resultado tipo doble
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Boton suma
        private void btnsuma_Click(object sender, EventArgs e)
        {
            //Se almacena en las variables lo que contiene la caja de texto
            VGlobal.num1 = Convert.ToDouble(txtnum1.Text);
            VGlobal.num2 = Convert.ToDouble(txtnum2.Text);

            //Proceso de suma
            VGlobal.resultado = VGlobal.num1 + VGlobal.num2;

            //El resultado se mostrara en la caja de texto
            txtresultado.Text = Convert.ToString(VGlobal.resultado);

        }

        //Boton resta
        private void btnresta_Click(object sender, EventArgs e)
        {
            //Se almacena en las variables lo que contiene la caja de texto
            VGlobal.num1 = Convert.ToDouble(txtnum1.Text);
            VGlobal.num2 = Convert.ToDouble(txtnum2.Text);

            //Proceso de resta
            VGlobal.resultado = VGlobal.num1 - VGlobal.num2;

            //El resultado se mostrara en la caja de texto
            txtresultado.Text = Convert.ToString(VGlobal.resultado);

        }

        //Boton multiplicacion
        private void btnmulti_Click(object sender, EventArgs e)
        {
            //Se almacena en las variables lo que contiene la caja de texto
            VGlobal.num1 = Convert.ToDouble(txtnum1.Text);
            VGlobal.num2 = Convert.ToDouble(txtnum2.Text);

            //Proceso de multiplicacion
            VGlobal.resultado = VGlobal.num1 * VGlobal.num2;

            //El resultado se mostrara en la caja de texto
            txtresultado.Text = Convert.ToString(VGlobal.resultado);

        }

        //Boton division
        private void btndiv_Click(object sender, EventArgs e)
        {
            //Se almacena en las variables lo que contiene la caja de texto
            VGlobal.num1 = Convert.ToDouble(txtnum1.Text);
            VGlobal.num2 = Convert.ToDouble(txtnum2.Text);

            //Proceso de division
            VGlobal.resultado = VGlobal.num1 / VGlobal.num2;

            //El resultado se mostrara en la caja de texto
            txtresultado.Text = Convert.ToString(Math.Round(VGlobal.resultado,2));//Solo 2 numeros despues del punto

        }
    }
}
