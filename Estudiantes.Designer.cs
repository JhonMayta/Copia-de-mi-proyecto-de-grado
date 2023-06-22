namespace Proyecto_de_Sistema_de_notas
{
    partial class Estudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiantes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDocentes = new FontAwesome.Sharp.IconButton();
            this.btnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.lbVerificador = new System.Windows.Forms.Label();
            this.Pintura2 = new System.Windows.Forms.PictureBox();
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.Conection = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.Pintura1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDocentes);
            this.panel2.Controls.Add(this.btnEstudiantes);
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 41);
            this.panel2.TabIndex = 82;
            // 
            // btnDocentes
            // 
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnDocentes.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnDocentes.IconColor = System.Drawing.Color.Black;
            this.btnDocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocentes.IconSize = 35;
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(0, 1);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(143, 39);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEstudiantes.IconColor = System.Drawing.Color.Black;
            this.btnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstudiantes.IconSize = 35;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(149, 1);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(143, 39);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblFechaHora);
            this.panel1.Controls.Add(this.lbCerrar);
            this.panel1.Controls.Add(this.lbVerificador);
            this.panel1.Controls.Add(this.Pintura2);
            this.panel1.Controls.Add(this.lbTitulo1);
            this.panel1.Controls.Add(this.Conection);
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.Pintura1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 126);
            this.panel1.TabIndex = 81;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaHora.Location = new System.Drawing.Point(416, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(60, 19);
            this.lblFechaHora.TabIndex = 29;
            this.lblFechaHora.Text = "label1";
            // 
            // lbCerrar
            // 
            this.lbCerrar.Location = new System.Drawing.Point(0, 0);
            this.lbCerrar.Name = "lbCerrar";
            this.lbCerrar.Size = new System.Drawing.Size(100, 23);
            this.lbCerrar.TabIndex = 0;
            // 
            // lbVerificador
            // 
            this.lbVerificador.AutoSize = true;
            this.lbVerificador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerificador.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbVerificador.Location = new System.Drawing.Point(97, 69);
            this.lbVerificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVerificador.Name = "lbVerificador";
            this.lbVerificador.Size = new System.Drawing.Size(54, 19);
            this.lbVerificador.TabIndex = 28;
            this.lbVerificador.Text = "Online";
            // 
            // Pintura2
            // 
            this.Pintura2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pintura2.Image = ((System.Drawing.Image)(resources.GetObject("Pintura2.Image")));
            this.Pintura2.Location = new System.Drawing.Point(1057, 4);
            this.Pintura2.Margin = new System.Windows.Forms.Padding(4);
            this.Pintura2.Name = "Pintura2";
            this.Pintura2.Size = new System.Drawing.Size(147, 122);
            this.Pintura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pintura2.TabIndex = 0;
            this.Pintura2.TabStop = false;
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo1.AutoSize = true;
            this.lbTitulo1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.ForeColor = System.Drawing.Color.White;
            this.lbTitulo1.Location = new System.Drawing.Point(720, 38);
            this.lbTitulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(251, 29);
            this.lbTitulo1.TabIndex = 1;
            this.lbTitulo1.Text = "Universidad Del Valle";
            // 
            // Conection
            // 
            this.Conection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Conection.Location = new System.Drawing.Point(180, 73);
            this.Conection.Margin = new System.Windows.Forms.Padding(4);
            this.Conection.Name = "Conection";
            this.Conection.Size = new System.Drawing.Size(15, 15);
            this.Conection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Conection.TabIndex = 27;
            this.Conection.TabStop = false;
            this.Conection.Click += new System.EventHandler(this.Conection_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(97, 44);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(75, 22);
            this.lbUsuario.TabIndex = 26;
            this.lbUsuario.Text = "Usuario";
            // 
            // Pintura1
            // 
            this.Pintura1.Image = ((System.Drawing.Image)(resources.GetObject("Pintura1.Image")));
            this.Pintura1.Location = new System.Drawing.Point(16, 26);
            this.Pintura1.Margin = new System.Windows.Forms.Padding(4);
            this.Pintura1.Name = "Pintura1";
            this.Pintura1.Size = new System.Drawing.Size(48, 48);
            this.Pintura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pintura1.TabIndex = 25;
            this.Pintura1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1191, 712);
            this.panelContenedor.TabIndex = 83;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 34);
            this.label1.TabIndex = 83;
            this.label1.Text = "¿Quieres saber cuanta nota tienes?";
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDocentes;
        private FontAwesome.Sharp.IconButton btnEstudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lbCerrar;
        public System.Windows.Forms.Label lbVerificador;
        private System.Windows.Forms.PictureBox Pintura2;
        private System.Windows.Forms.Label lbTitulo1;
        public System.Windows.Forms.PictureBox Conection;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.PictureBox Pintura1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}