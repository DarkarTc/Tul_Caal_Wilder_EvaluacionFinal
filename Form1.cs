using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace graficarepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            grafica_pastel.Titles.Add("Datos en forma de Pastel");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Obtenemos los datos ingresados por el usuario
                string[] series = txtNombresSeries.Text.Split(',');
                string[] puntosStr = txtPuntos.Text.Split(',');
                int[] puntos = new int[puntosStr.Length];

                // Convertimos los puntos a enteros
                for (int i = 0; i < puntosStr.Length; i++)
                {
                    if (int.TryParse(puntosStr[i], out int punto))
                    {
                        puntos[i] = punto;
                    }
                    else
                    {
                        // Si algún valor no es válido, mostramos un mensaje de error y salimos
                        MessageBox.Show("Por favor, ingrese valores válidos para los puntos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Limpiamos la gráfica antes de agregar los nuevos datos
                grafica_pastel.Series.Clear();

                // Creamos una nueva serie y configuramos el tipo de gráfico
                Series serie = new Series();
                serie.ChartType = SeriesChartType.Pie;

                // Agregamos los datos ingresados a la serie
                for (int i = 0; i < series.Length; i++)
                {
                    serie.Points.AddXY(series[i], puntos[i]);
                    serie.Points[i].Label = series[i];
                }

                // Agregamos la serie a la gráfica
                grafica_pastel.Series.Add(serie);
            
        }
    }
}
