namespace AppProyectoFinalCS4Semestre
{
    partial class FrmCodigoPostal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TVDatos = new System.Windows.Forms.TreeView();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCaracterSeparador = new System.Windows.Forms.TextBox();
            this.BtnGuardarCSV = new System.Windows.Forms.Button();
            this.BtnGuardarWord = new System.Windows.Forms.Button();
            this.BtnGuardarPDF = new System.Windows.Forms.Button();
            this.BtnGuardarOpenXml = new System.Windows.Forms.Button();
            this.BtnGuardarConInterop = new System.Windows.Forms.Button();
            this.LVDatos = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Location = new System.Drawing.Point(842, 518);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 37;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(833, 66);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 36;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.Color.LightGray;
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(11, 25);
            this.BtnAbrir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(70, 30);
            this.BtnAbrir.TabIndex = 35;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click_1);
            // 
            // TVDatos
            // 
            this.TVDatos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TVDatos.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDatos.Location = new System.Drawing.Point(487, 290);
            this.TVDatos.Margin = new System.Windows.Forms.Padding(2);
            this.TVDatos.Name = "TVDatos";
            this.TVDatos.Size = new System.Drawing.Size(319, 251);
            this.TVDatos.TabIndex = 34;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(487, 66);
            this.Chart1.Margin = new System.Windows.Forms.Padding(2);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(341, 193);
            this.Chart1.TabIndex = 33;
            this.Chart1.Text = "Chart1";
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click_1);
            // 
            // txtCaracterSeparador
            // 
            this.txtCaracterSeparador.Location = new System.Drawing.Point(531, 17);
            this.txtCaracterSeparador.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaracterSeparador.Name = "txtCaracterSeparador";
            this.txtCaracterSeparador.Size = new System.Drawing.Size(76, 20);
            this.txtCaracterSeparador.TabIndex = 32;
            // 
            // BtnGuardarCSV
            // 
            this.BtnGuardarCSV.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarCSV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCSV.Location = new System.Drawing.Point(256, 10);
            this.BtnGuardarCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarCSV.Name = "BtnGuardarCSV";
            this.BtnGuardarCSV.Size = new System.Drawing.Size(115, 35);
            this.BtnGuardarCSV.TabIndex = 31;
            this.BtnGuardarCSV.Text = "Guardar a CSV";
            this.BtnGuardarCSV.UseVisualStyleBackColor = false;
            this.BtnGuardarCSV.Click += new System.EventHandler(this.BtnGuardarCSV_Click_1);
            // 
            // BtnGuardarWord
            // 
            this.BtnGuardarWord.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarWord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarWord.Location = new System.Drawing.Point(388, 10);
            this.BtnGuardarWord.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarWord.Name = "BtnGuardarWord";
            this.BtnGuardarWord.Size = new System.Drawing.Size(104, 35);
            this.BtnGuardarWord.TabIndex = 30;
            this.BtnGuardarWord.Text = "Guardar a Word";
            this.BtnGuardarWord.UseVisualStyleBackColor = false;
            this.BtnGuardarWord.Click += new System.EventHandler(this.BtnGuardarWord_Click_1);
            // 
            // BtnGuardarPDF
            // 
            this.BtnGuardarPDF.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarPDF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarPDF.Location = new System.Drawing.Point(256, 50);
            this.BtnGuardarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarPDF.Name = "BtnGuardarPDF";
            this.BtnGuardarPDF.Size = new System.Drawing.Size(115, 36);
            this.BtnGuardarPDF.TabIndex = 29;
            this.BtnGuardarPDF.Text = "Guardar a PDF";
            this.BtnGuardarPDF.UseVisualStyleBackColor = false;
            this.BtnGuardarPDF.Click += new System.EventHandler(this.BtnGuardarPDF_Click_1);
            // 
            // BtnGuardarOpenXml
            // 
            this.BtnGuardarOpenXml.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarOpenXml.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarOpenXml.Location = new System.Drawing.Point(98, 49);
            this.BtnGuardarOpenXml.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarOpenXml.Name = "BtnGuardarOpenXml";
            this.BtnGuardarOpenXml.Size = new System.Drawing.Size(132, 36);
            this.BtnGuardarOpenXml.TabIndex = 28;
            this.BtnGuardarOpenXml.Text = "Guardar con OpenXml";
            this.BtnGuardarOpenXml.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarConInterop
            // 
            this.BtnGuardarConInterop.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarConInterop.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarConInterop.Location = new System.Drawing.Point(98, 10);
            this.BtnGuardarConInterop.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarConInterop.Name = "BtnGuardarConInterop";
            this.BtnGuardarConInterop.Size = new System.Drawing.Size(132, 35);
            this.BtnGuardarConInterop.TabIndex = 27;
            this.BtnGuardarConInterop.Text = "Guardar con Interop";
            this.BtnGuardarConInterop.UseVisualStyleBackColor = false;
            this.BtnGuardarConInterop.Click += new System.EventHandler(this.BtnGuardarConInterop_Click_1);
            // 
            // LVDatos
            // 
            this.LVDatos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LVDatos.HideSelection = false;
            this.LVDatos.Location = new System.Drawing.Point(9, 90);
            this.LVDatos.Margin = new System.Windows.Forms.Padding(2);
            this.LVDatos.Name = "LVDatos";
            this.LVDatos.Size = new System.Drawing.Size(474, 451);
            this.LVDatos.TabIndex = 26;
            this.LVDatos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmCodigoPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 550);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TVDatos);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.txtCaracterSeparador);
            this.Controls.Add(this.BtnGuardarCSV);
            this.Controls.Add(this.BtnGuardarWord);
            this.Controls.Add(this.BtnGuardarPDF);
            this.Controls.Add(this.BtnGuardarOpenXml);
            this.Controls.Add(this.BtnGuardarConInterop);
            this.Controls.Add(this.LVDatos);
            this.Name = "FrmCodigoPostal";
            this.Text = "FrmCodigoPostal";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TreeView TVDatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.TextBox txtCaracterSeparador;
        private System.Windows.Forms.Button BtnGuardarCSV;
        private System.Windows.Forms.Button BtnGuardarWord;
        private System.Windows.Forms.Button BtnGuardarPDF;
        private System.Windows.Forms.Button BtnGuardarOpenXml;
        private System.Windows.Forms.Button BtnGuardarConInterop;
        private System.Windows.Forms.ListView LVDatos;
    }
}