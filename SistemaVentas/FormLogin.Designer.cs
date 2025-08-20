
namespace SistemaVentas
{
    partial class FormLogin
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
            this.txtEtiqueta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtDesarrollado = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.AutoSize = true;
            this.txtEtiqueta.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtiqueta.ForeColor = System.Drawing.Color.White;
            this.txtEtiqueta.Location = new System.Drawing.Point(59, 11);
            this.txtEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(579, 52);
            this.txtEtiqueta.TabIndex = 0;
            this.txtEtiqueta.Text = "ACCESO AL SISTEMA SIV";
            this.txtEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(16, 110);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 39);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario:";
            // 
            // pbLogin
            // 
            this.pbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbLogin.Location = new System.Drawing.Point(0, -1);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(857, 79);
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(16, 202);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(202, 39);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(241, 123);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(325, 22);
            this.tbUsuario.TabIndex = 4;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(241, 215);
            this.tbContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(325, 22);
            this.tbContrasena.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(576, 110);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(265, 151);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDesarrollado
            // 
            this.txtDesarrollado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesarrollado.AutoSize = true;
            this.txtDesarrollado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesarrollado.Location = new System.Drawing.Point(16, 271);
            this.txtDesarrollado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDesarrollado.Name = "txtDesarrollado";
            this.txtDesarrollado.Size = new System.Drawing.Size(0, 25);
            this.txtDesarrollado.TabIndex = 7;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.AutoSize = true;
            this.txtVersion.Location = new System.Drawing.Point(745, 279);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(86, 16);
            this.txtVersion.TabIndex = 8;
            this.txtVersion.Text = "Versión: 1.0.0";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 306);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDesarrollado);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEtiqueta;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtDesarrollado;
        private System.Windows.Forms.Label txtVersion;
    }
}