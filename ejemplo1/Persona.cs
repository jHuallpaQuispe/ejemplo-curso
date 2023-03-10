using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    internal class Persona
    {
        // Nombre, 

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public string Chocolate { get; set; }

        public string Novia { get; set; }

        public string Tipo { get; set; }
        public void Tipos(bool ckMuggle, bool ckWizard){

            if (ckMuggle)
                Tipo = "Muggle";
            else if (ckWizard)
                Tipo = "Wizard";
            else
                Tipo = "Squibs";
        }

        public string ColorFavorito { get; set; }
        public string NroFavorito { get; set; }


        public DialogResult Saludar()
        {
            string message = Chocolate + Novia + "\nEres de tipo: " + Tipo + "\nTu color favorito: " + ColorFavorito + "\nNumero Favorito: " + NroFavorito;
            return MessageBox.Show("Hola como estas " + Nombre + "\nFecha: " + Fecha + message);
        }
    }
}
