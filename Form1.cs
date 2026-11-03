using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCursos
{
    public partial class Form1 : Form
    {
        string ruta = Application.StartupPath + "\\cursos.txt";
        //MessageBox.Show(ruta);
        string[] lineas;
        public Form1()
        {
            InitializeComponent();
            dgvCursos.Columns.Add("Codigo", "Código");
            dgvCursos.Columns.Add("Curso", "Curso");
            dgvCursos.Columns.Add("Area", "Área");
            dgvCursos.Columns.Add("Costo", "Costo");
            dgvCursos.Columns.Add("Vacantes", "Vacantes");
            dgvCursos.Columns.Add("Disponibilidad", "Disponibilidad");
        }

        // Determinar disponibilidad
        string Disponibilidad(int vacantes)
        {
            if (vacantes == 0)
                return "Sin vacantes";
            else if (vacantes <= 5)
                return "Pocas vacantes";
            else
                return "Disponible";
        }

        // Calcular resumen
        void CalcularResumen()
        {
            int total = 0;
            int sinVacantes = 0;
            int pocasVacantes = 0;

            decimal valorTotal = 0;
            decimal mayorCosto = 0;
            string cursoMayor = "";

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');

                if (datos.Length == 5)
                {
                    decimal costo = decimal.Parse(
                        datos[3], CultureInfo.InvariantCulture);

                    int vacantes = int.Parse(datos[4]);

                    total++;

                    if (vacantes == 0)
                        sinVacantes++;
                    else if (vacantes <= 5)
                        pocasVacantes++;

                    valorTotal += costo * vacantes;

                    if (total == 1 || costo > mayorCosto)
                    {
                        mayorCosto = costo;
                        cursoMayor = datos[1];
                    }
                }
            }

            lblTotal.Text = "Total de cursos: " + total;
            lblSinVacantes.Text = "Sin vacantes: " + sinVacantes;
            lblPocasVacantes.Text = "Pocas vacantes: " + pocasVacantes;

            lblValorTotal.Text = "Valor total: S/ " +
                valorTotal.ToString("0.00");

            lblMayorCosto.Text = "Mayor costo: " +
                cursoMayor + " - S/ " + mayorCosto.ToString("0.00");
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un código.");
                return;
            }

            if (lineas == null)
            {
                MessageBox.Show("Primero cargue los cursos.");
                return;
            }

            bool encontrado = false;

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');

                if (datos.Length == 5 &&
                    datos[0].Equals(txtCodigo.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    int vacantes = int.Parse(datos[4]);

                    lblCodigo.Text = "Código: " + datos[0];
                    lblCurso.Text = "Curso: " + datos[1];
                    lblArea.Text = "Área: " + datos[2];
                    lblCosto.Text = "Costo: S/ " + datos[3];
                    lblVacantes.Text = "Vacantes: " + datos[4];

                    lblDisponibilidad.Text =
                        "Disponibilidad: " + Disponibilidad(vacantes);

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Curso no encontrado.");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró cursos.txt");
                return;
            }

            lineas = File.ReadAllLines(ruta);
            dgvCursos.Rows.Clear();

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');

                if (datos.Length == 5)
                {
                    decimal costo = decimal.Parse(
                        datos[3], CultureInfo.InvariantCulture);

                    int vacantes = int.Parse(datos[4]);

                    dgvCursos.Rows.Add(
                        datos[0],
                        datos[1],
                        datos[2],
                        costo,
                        vacantes,
                        Disponibilidad(vacantes)
                    );
                }
            }

            CalcularResumen();

            MessageBox.Show("Cursos cargados correctamente.");
        }
    }
}
