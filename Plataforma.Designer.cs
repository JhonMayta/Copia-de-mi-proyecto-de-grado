namespace Proyecto_de_Sistema_de_notas
{
    partial class Plataforma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plataforma));
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbSistema = new System.Windows.Forms.GroupBox();
            this.txtActividad3 = new System.Windows.Forms.TextBox();
            this.txtActividad2 = new System.Windows.Forms.TextBox();
            this.txtActividad1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.lbVerificador = new System.Windows.Forms.Label();
            this.Pintura2 = new System.Windows.Forms.PictureBox();
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.Conection = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.Pintura1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDocentes = new FontAwesome.Sharp.IconButton();
            this.btnEstudiantes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.gbSistema.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvlistado
            // 
            this.dgvlistado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlistado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.dgvlistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvlistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvlistado.ColumnHeadersHeight = 30;
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistado.EnableHeadersVisualStyles = false;
            this.dgvlistado.GridColor = System.Drawing.Color.Silver;
            this.dgvlistado.Location = new System.Drawing.Point(36, 191);
            this.dgvlistado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.RowHeadersVisible = false;
            this.dgvlistado.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvlistado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(690, 411);
            this.dgvlistado.TabIndex = 74;
            this.dgvlistado.DoubleClick += new System.EventHandler(this.dgvlistado_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Proyecto_de_Sistema_de_notas.Properties.Resources.delete_bin_24px;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(36, 615);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 52);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbSistema
            // 
            this.gbSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSistema.Controls.Add(this.txtActividad3);
            this.gbSistema.Controls.Add(this.txtActividad2);
            this.gbSistema.Controls.Add(this.txtActividad1);
            this.gbSistema.Controls.Add(this.txtNombre);
            this.gbSistema.Controls.Add(this.txtCarnet);
            this.gbSistema.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistema.Location = new System.Drawing.Point(725, 191);
            this.gbSistema.Margin = new System.Windows.Forms.Padding(4);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Padding = new System.Windows.Forms.Padding(4);
            this.gbSistema.Size = new System.Drawing.Size(425, 411);
            this.gbSistema.TabIndex = 72;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Sistema de Docentes";
            // 
            // txtActividad3
            // 
            this.txtActividad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtActividad3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad3.ForeColor = System.Drawing.Color.Gray;
            this.txtActividad3.Location = new System.Drawing.Point(44, 375);
            this.txtActividad3.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad3.Name = "txtActividad3";
            this.txtActividad3.Size = new System.Drawing.Size(363, 30);
            this.txtActividad3.TabIndex = 14;
            this.txtActividad3.Text = "Parcial 3(30%)";
            this.txtActividad3.TextChanged += new System.EventHandler(this.txtActividad3_TextChanged);
            this.txtActividad3.Enter += new System.EventHandler(this.txtActividad3_Enter);
            this.txtActividad3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad3_KeyPress);
            this.txtActividad3.Leave += new System.EventHandler(this.txtActividad3_Leave);
            // 
            // txtActividad2
            // 
            this.txtActividad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtActividad2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad2.ForeColor = System.Drawing.Color.Gray;
            this.txtActividad2.Location = new System.Drawing.Point(44, 328);
            this.txtActividad2.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad2.Name = "txtActividad2";
            this.txtActividad2.Size = new System.Drawing.Size(363, 30);
            this.txtActividad2.TabIndex = 13;
            this.txtActividad2.Text = "Parcial 2(35%)";
            this.txtActividad2.TextChanged += new System.EventHandler(this.txtActividad2_TextChanged);
            this.txtActividad2.Enter += new System.EventHandler(this.txtActividad2_Enter);
            this.txtActividad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad2_KeyPress);
            this.txtActividad2.Leave += new System.EventHandler(this.txtActividad2_Leave);
            // 
            // txtActividad1
            // 
            this.txtActividad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtActividad1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad1.ForeColor = System.Drawing.Color.Gray;
            this.txtActividad1.Location = new System.Drawing.Point(44, 279);
            this.txtActividad1.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad1.Name = "txtActividad1";
            this.txtActividad1.Size = new System.Drawing.Size(363, 30);
            this.txtActividad1.TabIndex = 12;
            this.txtActividad1.Text = "Parcial 1(35%)";
            this.txtActividad1.TextChanged += new System.EventHandler(this.txtActividad1_TextChanged);
            this.txtActividad1.Enter += new System.EventHandler(this.txtActividad1_Enter);
            this.txtActividad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad1_KeyPress);
            this.txtActividad1.Leave += new System.EventHandler(this.txtActividad1_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(44, 192);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 30);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Nombre/Apellidos";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtCarnet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.ForeColor = System.Drawing.Color.Gray;
            this.txtCarnet.Location = new System.Drawing.Point(44, 154);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(363, 30);
            this.txtCarnet.TabIndex = 10;
            this.txtCarnet.Text = "Carnet";
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            this.txtCarnet.Enter += new System.EventHandler(this.txtCarnet_Enter);
            this.txtCarnet.Leave += new System.EventHandler(this.txtCarnet_Leave);
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
            this.panel1.TabIndex = 75;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Proyecto_de_Sistema_de_notas.Properties.Resources.save_as_32px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(780, 615);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(303, 52);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnDocentes);
            this.panel2.Controls.Add(this.btnEstudiantes);
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 40);
            this.panel2.TabIndex = 76;
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
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // Plataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1191, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 758);
            this.Name = "Plataforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plataforma";
            this.Load += new System.EventHandler(this.Plataforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.gbSistema.ResumeLayout(false);
            this.gbSistema.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pintura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbSistema;
        private System.Windows.Forms.TextBox txtActividad3;
        private System.Windows.Forms.TextBox txtActividad2;
        private System.Windows.Forms.TextBox txtActividad1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCerrar;
        public System.Windows.Forms.Label lbVerificador;
        private System.Windows.Forms.PictureBox Pintura2;
        private System.Windows.Forms.Label lbTitulo1;
        public System.Windows.Forms.PictureBox Conection;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.PictureBox Pintura1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEstudiantes;
        private FontAwesome.Sharp.IconButton btnDocentes;
    }
}