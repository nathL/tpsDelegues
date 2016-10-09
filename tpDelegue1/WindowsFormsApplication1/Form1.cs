using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public delegate int Operation(int x);

        private static int ExecuterOperation(Operation operationAeffectuer, int x)
        {
            return operationAeffectuer(x);
        }
        public int Incremente(int x)
        {
            return x + 1; 
        }
        public int Decremente(int x)
        {
            return x - 1; 
        }
        public int Carre(int x)
        {
            return (int)Math.Pow(x,2);
        }
        public int Cube(int x)
        {
            return (int)Math.Pow(x, 3);
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Incrementer le nombre");
            comboBox1.Items.Add("Décrémenter le nombre");
            comboBox1.Items.Add("Calculer le carré du nombre");
            comboBox1.Items.Add("Calculer le cube du nombre");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number;
            String value = txtSaisie.Text;
            Operation operation = null;
            if (Int32.TryParse(value, out number))
            {
                if ((string)comboBox1.SelectedItem == "Incrementer le nombre")
                {
                    operation = Incremente;
                } else if ((string)comboBox1.SelectedItem == "Décrémenter le nombre")
                {
                    operation = Decremente;
                } else if ((string)comboBox1.SelectedItem == "Calculer le carré du nombre")
                {
                    operation = Carre;
                } else if ((string)comboBox1.SelectedItem == "Calculer le cube du nombre")
                {
                    operation = Cube;
                }
                lblResultat.Text = operation(number).ToString();
            }
            else
            {
                lblResultat.Text = "Erreur";
            }

        }
    }
}
