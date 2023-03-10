using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text + "\t\t\n"+ cboSexo.SelectedItem.ToString();
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Blanco");

            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
            cboSexo.Items.Add("Compañere");
            cboSexo.Items.Add("No binario");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Fecha = dtpFechaNacimiento.Value;
            //operador ternario : Es un if de una sola linea
            p1.Chocolate = ckbChocolate.Checked == true ? "\nLe gusta chocolate": "\nOdia el chocolate";
            p1.Novia = ckbNovia.Checked == true ? "\nTiene novia "  : "\nNo tiene novia :(";

            p1.Tipos(rbtMuggle.Checked, rbtWizard.Checked);
            //string tipo;
            //if (rbtMuggle.Checked)
            //    tipo = "Muggle";
            //else if (rbtWizard.Checked)
            //    tipo = "Wizard";
            //else
            //    tipo = "Squibs";

            p1.ColorFavorito = cboColorFavorito.SelectedItem.ToString();
            p1.NroFavorito = numNumeroFavorito.Value.ToString();

            p1.Saludar();

            //string mensaje = chocolate+ "\nEs " + tipo + "\nSu color es " + colorFavorito + "\n" +novia + "\nSu número es: "+ numeroFavorito;
            //MessageBox.Show("Nombre: " + nombre + "\nFecha: " + fecha + "\n" + mensaje);
        }
    }
}
