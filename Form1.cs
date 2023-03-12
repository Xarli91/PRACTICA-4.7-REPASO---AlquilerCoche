using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4._7_REPASO___AlquilerCoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int kmInicio = Convert.ToInt32(numKmInicio.Value);
            int kmFin = Convert.ToInt32(numKmFin.Value);

            if (kmInicio >= kmFin)
            {
                MessageBox.Show("El valor de los Km de inicio no puede ser mayor que los km de finalización");
                return;
            }

            int kmRecorridos = kmFin - kmInicio;
            double precio = kmRecorridos * 0.39;

            lblPrecio.Text = $"El precio a pagar es: {precio.ToString("0.00")} €";
        }

    }
}
