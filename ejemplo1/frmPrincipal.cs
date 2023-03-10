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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Application.OpenForms--> se ve que ventanas hay abiertas,en este metodo se agregan las ventanas que estan abiertas 
            foreach (var item in Application.OpenForms) // Las ventanas que estan abiertas estan referenciadas acá
            {
                if (item.GetType() == typeof(Form1)) // para la 1era vuelta la ventana form1 no esta abierta ,por lo tanto no va encontrar el tipo.. pero para la 2da vuelta estará abierta y bueno se cancela
                {
                    MessageBox.Show("Ya existe una venta abierta,termine de trabajar allí...");

                    return;
                }
            }   
            Form1 ventana = new Form1();
            ventana.MdiParent = this; // this, se fiere a este ventana
            ventana.Show();
            //ventana.ShowDialog(); // La ventana que se abre, toma el control y no te permite que lo de atras se puede manipular hasta que vos no cierres la ventana(solo 1 ventana te permite abrir)
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {

            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una venta abierta,termine de trabajar allí...");
                    return;
                }
            }
            Form1 ventana = new Form1();
            ventana.MdiParent= this;
            ventana.Show();
        }
    }
}
