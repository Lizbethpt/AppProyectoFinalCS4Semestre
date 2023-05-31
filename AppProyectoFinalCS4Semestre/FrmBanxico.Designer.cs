namespace AppProyectoFinalCS4Semestre
{
    partial class FrmBanxico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblFechaFinal = new System.Windows.Forms.Label();
            this.LblFechainicio = new System.Windows.Forms.Label();
            this.TVDatos = new System.Windows.Forms.TreeView();
            this.DTFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DTFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(471, 46);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(300, 300);
            this.Chart1.TabIndex = 36;
            this.Chart1.Text = "chart1";
            this.Chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(786, 284);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(84, 28);
            this.BtnLimpiar.TabIndex = 35;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(802, 491);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(84, 28);
            this.BtnCerrar.TabIndex = 34;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // LblFechaFinal
            // 
            this.LblFechaFinal.AutoSize = true;
            this.LblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFinal.Location = new System.Drawing.Point(8, 41);
            this.LblFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaFinal.Name = "LblFechaFinal";
            this.LblFechaFinal.Size = new System.Drawing.Size(75, 16);
            this.LblFechaFinal.TabIndex = 33;
            this.LblFechaFinal.Text = "Fecha Final";
            // 
            // LblFechainicio
            // 
            this.LblFechainicio.AutoSize = true;
            this.LblFechainicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechainicio.Location = new System.Drawing.Point(8, 7);
            this.LblFechainicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechainicio.Name = "LblFechainicio";
            this.LblFechainicio.Size = new System.Drawing.Size(95, 16);
            this.LblFechainicio.TabIndex = 32;
            this.LblFechainicio.Text = "Fecha de Inicio";
            // 
            // TVDatos
            // 
            this.TVDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TVDatos.Location = new System.Drawing.Point(11, 71);
            this.TVDatos.Margin = new System.Windows.Forms.Padding(2);
            this.TVDatos.Name = "TVDatos";
            this.TVDatos.Size = new System.Drawing.Size(429, 422);
            this.TVDatos.TabIndex = 31;
            // 
            // DTFechaFinal
            // 
            this.DTFechaFinal.Location = new System.Drawing.Point(128, 37);
            this.DTFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.DTFechaFinal.Name = "DTFechaFinal";
            this.DTFechaFinal.Size = new System.Drawing.Size(151, 20);
            this.DTFechaFinal.TabIndex = 30;
            // 
            // DTFechaInicial
            // 
            this.DTFechaInicial.Location = new System.Drawing.Point(128, 3);
            this.DTFechaInicial.Margin = new System.Windows.Forms.Padding(2);
            this.DTFechaInicial.Name = "DTFechaInicial";
            this.DTFechaInicial.Size = new System.Drawing.Size(151, 20);
            this.DTFechaInicial.TabIndex = 29;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Silver;
            this.BtnConsultar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.Black;
            this.BtnConsultar.Location = new System.Drawing.Point(311, 20);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(84, 28);
            this.BtnConsultar.TabIndex = 28;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            // 
            // FrmBanxico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(898, 530);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblFechaFinal);
            this.Controls.Add(this.LblFechainicio);
            this.Controls.Add(this.TVDatos);
            this.Controls.Add(this.DTFechaFinal);
            this.Controls.Add(this.DTFechaInicial);
            this.Controls.Add(this.BtnConsultar);
            this.Name = "FrmBanxico";
            this.Text = "FrmBanxico";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblFechaFinal;
        private System.Windows.Forms.Label LblFechainicio;
        private System.Windows.Forms.TreeView TVDatos;
        private System.Windows.Forms.DateTimePicker DTFechaFinal;
        private System.Windows.Forms.DateTimePicker DTFechaInicial;
        private System.Windows.Forms.Button BtnConsultar;
    }
}