namespace Controles
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
            this.btnAcerptar = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cbcaja = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcerptar
            // 
            this.btnAcerptar.Location = new System.Drawing.Point(12, 12);
            this.btnAcerptar.Name = "btnAcerptar";
            this.btnAcerptar.Size = new System.Drawing.Size(75, 23);
            this.btnAcerptar.TabIndex = 0;
            this.btnAcerptar.Text = "aceptar";
            this.btnAcerptar.UseVisualStyleBackColor = true;
            this.btnAcerptar.MouseEnter += new System.EventHandler(this.BtnAcerptar_MouseEnter);
            this.btnAcerptar.MouseLeave += new System.EventHandler(this.BtnAcerptar_MouseLeave);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(104, 17);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(35, 13);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "label1";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(157, 15);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 2;
            this.nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            this.nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nombre_KeyDown);
            // 
            // cbcaja
            // 
            this.cbcaja.AutoSize = true;
            this.cbcaja.Location = new System.Drawing.Point(22, 59);
            this.cbcaja.Name = "cbcaja";
            this.cbcaja.Size = new System.Drawing.Size(80, 17);
            this.cbcaja.TabIndex = 3;
            this.cbcaja.Text = "checkBox1";
            this.cbcaja.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 208);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(12, 115);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(59, 38);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.Btnnext_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbcaja);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnAcerptar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAcerptar;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.CheckBox cbcaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnnext;
    }
}

