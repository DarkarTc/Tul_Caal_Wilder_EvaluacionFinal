
namespace graficarepaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica_pastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombresSeries = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_pastel)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica_pastel
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica_pastel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica_pastel.Legends.Add(legend1);
            this.grafica_pastel.Location = new System.Drawing.Point(260, 12);
            this.grafica_pastel.Name = "grafica_pastel";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica_pastel.Series.Add(series1);
            this.grafica_pastel.Size = new System.Drawing.Size(300, 300);
            this.grafica_pastel.TabIndex = 0;
            this.grafica_pastel.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombresSeries
            // 
            this.txtNombresSeries.Location = new System.Drawing.Point(126, 42);
            this.txtNombresSeries.Name = "txtNombresSeries";
            this.txtNombresSeries.Size = new System.Drawing.Size(100, 20);
            this.txtNombresSeries.TabIndex = 2;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(126, 81);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 20);
            this.txtPuntos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtNombresSeries);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grafica_pastel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafica_pastel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_pastel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombresSeries;
        private System.Windows.Forms.TextBox txtPuntos;
    }
}

