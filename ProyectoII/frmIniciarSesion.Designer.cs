namespace ProyectoII
{
    partial class frmIniciarSesion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gblogin = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 371);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoII.Properties.Resources.logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gblogin
            // 
            this.gblogin.Controls.Add(this.btnEnter);
            this.gblogin.Controls.Add(this.txtpassword);
            this.gblogin.Controls.Add(this.txtUsername);
            this.gblogin.Controls.Add(this.lblpassword);
            this.gblogin.Controls.Add(this.lblUsername);
            this.gblogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblogin.Location = new System.Drawing.Point(290, 48);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(443, 295);
            this.gblogin.TabIndex = 1;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "Iniciar Sesion";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(188, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "nombre de Usuario";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(16, 176);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(112, 28);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "contraseña";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(210, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(212, 35);
            this.txtUsername.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(134, 173);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(288, 35);
            this.txtpassword.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnter.Location = new System.Drawing.Point(200, 239);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(222, 39);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Ingresar";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(746, 355);
            this.ControlBox = false;
            this.Controls.Add(this.gblogin);
            this.Controls.Add(this.panel1);
            this.Name = "frmIniciarSesion";
            this.Text = "Iniciar Sesion Colegio Universitario de Cartago";
            this.Load += new System.EventHandler(this.frmIniciarSesion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gblogin.ResumeLayout(false);
            this.gblogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gblogin;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUsername;
    }
}

