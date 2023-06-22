namespace Proyecto_de_Sistema_de_notas
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.linkRegistrado = new System.Windows.Forms.LinkLabel();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnInvisible = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Pintura1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkRegistrado
            // 
            this.linkRegistrado.AutoSize = true;
            this.linkRegistrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrado.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkRegistrado.Location = new System.Drawing.Point(340, 562);
            this.linkRegistrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRegistrado.Name = "linkRegistrado";
            this.linkRegistrado.Size = new System.Drawing.Size(97, 19);
            this.linkRegistrado.TabIndex = 55;
            this.linkRegistrado.TabStop = true;
            this.linkRegistrado.Text = "Registrarse";
            this.linkRegistrado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrado_LinkClicked_1);
            // 
            // lbInfo1
            // 
            this.lbInfo1.AutoSize = true;
            this.lbInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.lbInfo1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo1.Location = new System.Drawing.Point(120, 562);
            this.lbInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(205, 21);
            this.lbInfo1.TabIndex = 54;
            this.lbInfo1.Text = "¿No te has Registrado?";
            // 
            // btnVisible
            // 
            this.btnVisible.FlatAppearance.BorderSize = 0;
            this.btnVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible.Image = ((System.Drawing.Image)(resources.GetObject("btnVisible.Image")));
            this.btnVisible.Location = new System.Drawing.Point(569, 360);
            this.btnVisible.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(44, 28);
            this.btnVisible.TabIndex = 52;
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click_1);
            // 
            // btnInvisible
            // 
            this.btnInvisible.FlatAppearance.BorderSize = 0;
            this.btnInvisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvisible.Image = ((System.Drawing.Image)(resources.GetObject("btnInvisible.Image")));
            this.btnInvisible.Location = new System.Drawing.Point(569, 360);
            this.btnInvisible.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(44, 28);
            this.btnInvisible.TabIndex = 51;
            this.btnInvisible.UseVisualStyleBackColor = true;
            this.btnInvisible.Visible = false;
            this.btnInvisible.Click += new System.EventHandler(this.btnInvisible_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(69, 448);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(461, 52);
            this.btnIngresar.TabIndex = 50;
            this.btnIngresar.Text = "Iniciar Sesión";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(69, 358);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.MaxLength = 15;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(460, 30);
            this.txtContraseña.TabIndex = 49;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(69, 284);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 13;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(460, 30);
            this.txtUsuario.TabIndex = 48;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // Pintura1
            // 
            this.Pintura1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pintura1.Image = ((System.Drawing.Image)(resources.GetObject("Pintura1.Image")));
            this.Pintura1.Location = new System.Drawing.Point(0, 0);
            this.Pintura1.Margin = new System.Windows.Forms.Padding(4);
            this.Pintura1.Name = "Pintura1";
            this.Pintura1.Size = new System.Drawing.Size(750, 256);
            this.Pintura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pintura1.TabIndex = 47;
            this.Pintura1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(750, 647);
            this.Controls.Add(this.linkRegistrado);
            this.Controls.Add(this.lbInfo1);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnInvisible);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Pintura1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesion";
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkRegistrado;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnInvisible;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox Pintura1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

