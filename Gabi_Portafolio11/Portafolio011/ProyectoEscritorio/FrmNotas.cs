using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace ProyectoEscritorio
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            //Ver Resultado
            ClsPromedio prom = new ClsPromedio();
            prom.Promedio = SumarNotas();

            if (lstNotasIngresadas.Items.Count == 0)
            {
                MessageBox.Show("La lista está vacía, no se puede calcular el promedio");
                return;
            }

            double sumaNotas = SumarNotas();

            double valorPromedio = prom.CalculoPromedio(sumaNotas, lstNotasIngresadas.Items.Count);

            Dictionary<string, string> condicionFinal = prom.calculoCondicion(valorPromedio);

            if (condicionFinal["Condicion"] == "APROBADO")
            {
                txtMostrarPromedio.Text = valorPromedio.ToString()+ "- APROBADO";
                txtMostrarPromedio.BackColor = Color.Green;
                txtMostrarPromedio.ForeColor = Color.White;
            }
            else
            {
                txtMostrarPromedio.Text = valorPromedio.ToString() + "- REPROBADO";
                txtMostrarPromedio.BackColor = Color.Red;
                txtMostrarPromedio.ForeColor = Color.White;
            }





        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string notaText = txtNota.Text;

            //Valida si el campo está vacío.. El sistema debe validar que se (a)haya indicado un valor, (b)que valor escrito sea numérico y que dicho (c) valor no sea un número superior a 100.
            if (string.IsNullOrWhiteSpace(notaText))
            {
                MessageBox.Show("Ingrese un nota.");
                return;
            }
            if (!int.TryParse(notaText, out int nota))
            {
                MessageBox.Show("Se ha digitado una entrada no numérica.");
                return;
            }

            if (nota <0 || nota > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100.");
                return;
            }

            //Agrega la nota a la lista
            lstNotasIngresadas.Items.Add(nota);
           
            //Limpiar cuadro de texto de la nota
            txtNota.Text = string.Empty;
            txtNota.Focus();
        }

        private double SumarNotas()
        {
            double suma = 0;
            foreach (object item in lstNotasIngresadas.Items)
            {
                if (item is double nota)
                {
                    suma += nota;
                }
                else if (double.TryParse(item.ToString(), out double notaD))
                {
                    suma += notaD;
                }
            }

            return suma;
        }

        private void lstNotasIngresadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotasIngresadas.SelectedIndex != -1)
            {
                int notaSeleccionada = (int)lstNotasIngresadas.SelectedItem;
                txtNotaSeleccionada.Text = notaSeleccionada.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstNotasIngresadas.SelectedIndex != -1)
            {
                lstNotasIngresadas.Items.RemoveAt(lstNotasIngresadas.SelectedIndex);
                txtNota.Text = string.Empty;
                txtNotaSeleccionada.Text = string.Empty;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstNotasIngresadas.Items.Clear();
            txtMostrarPromedio.Clear();
            txtMostrarPromedio.BackColor = SystemColors.Info;
        }
    }
}
