namespace AppProyectoFinalCS4Semestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PBInegi = new System.Windows.Forms.PictureBox();
            this.PBBanxico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBInegi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBanxico)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(542, 271);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // PBInegi
            // 
            this.PBInegi.Image = ((System.Drawing.Image)(resources.GetObject("PBInegi.Image")));
            this.PBInegi.Location = new System.Drawing.Point(372, 101);
            this.PBInegi.Name = "PBInegi";
            this.PBInegi.Size = new System.Drawing.Size(156, 109);
            this.PBInegi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInegi.TabIndex = 9;
            this.PBInegi.TabStop = false;
            this.PBInegi.Click += new System.EventHandler(this.PBInegi_Click_1);
            // 
            // PBBanxico
            // 
            this.PBBanxico.Image = ((System.Drawing.Image)(resources.GetObject("PBBanxico.Image")));
            this.PBBanxico.Location = new System.Drawing.Point(147, 101);
            this.PBBanxico.Name = "PBBanxico";
            this.PBBanxico.Size = new System.Drawing.Size(169, 109);
            this.PBBanxico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBanxico.TabIndex = 8;
            this.PBBanxico.TabStop = false;
            this.PBBanxico.Click += new System.EventHandler(this.PBBanxico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(629, 306);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PBInegi);
            this.Controls.Add(this.PBBanxico);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBInegi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBanxico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox PBInegi;
        private System.Windows.Forms.PictureBox PBBanxico;
    }
}

