namespace FacturacionP5_Jessica.Formularios
{
    partial class FrmUsuariosGestion
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
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.CboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmailRespaldo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiarForm = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.BtnVerPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.GbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CNombreUsuario,
            this.CCedula,
            this.CRol});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(12, 45);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(776, 137);
            this.DgvListaUsuarios.TabIndex = 0;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "Código Usuario";
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CNombreUsuario
            // 
            this.CNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreUsuario.DataPropertyName = "NombreUsuario";
            this.CNombreUsuario.HeaderText = "Email";
            this.CNombreUsuario.Name = "CNombreUsuario";
            this.CNombreUsuario.ReadOnly = true;
            this.CNombreUsuario.Width = 180;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 150;
            // 
            // CRol
            // 
            this.CRol.DataPropertyName = "Rol";
            this.CRol.HeaderText = "Tipo Usuario";
            this.CRol.Name = "CRol";
            this.CRol.ReadOnly = true;
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.BtnVerPassword);
            this.GbDetalles.Controls.Add(this.CboxTipoUsuario);
            this.GbDetalles.Controls.Add(this.label8);
            this.GbDetalles.Controls.Add(this.textBox8);
            this.GbDetalles.Controls.Add(this.TxtPassword);
            this.GbDetalles.Controls.Add(this.label10);
            this.GbDetalles.Controls.Add(this.label7);
            this.GbDetalles.Controls.Add(this.TxtEmailRespaldo);
            this.GbDetalles.Controls.Add(this.label9);
            this.GbDetalles.Controls.Add(this.TxtTelefono);
            this.GbDetalles.Controls.Add(this.label6);
            this.GbDetalles.Controls.Add(this.TxtCedula);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Controls.Add(this.TxtNombre);
            this.GbDetalles.Controls.Add(this.TxtEmail);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.TxtCodigo);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Location = new System.Drawing.Point(12, 196);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(776, 167);
            this.GbDetalles.TabIndex = 1;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de usuario";
            // 
            // CboxTipoUsuario
            // 
            this.CboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoUsuario.FormattingEnabled = true;
            this.CboxTipoUsuario.Location = new System.Drawing.Point(446, 124);
            this.CboxTipoUsuario.Name = "CboxTipoUsuario";
            this.CboxTipoUsuario.Size = new System.Drawing.Size(294, 21);
            this.CboxTipoUsuario.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo Usuario";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(556, -39);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 11;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(446, 88);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(232, 20);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, -36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contraseña";
            // 
            // TxtEmailRespaldo
            // 
            this.TxtEmailRespaldo.Location = new System.Drawing.Point(446, 50);
            this.TxtEmailRespaldo.Name = "TxtEmailRespaldo";
            this.TxtEmailRespaldo.Size = new System.Drawing.Size(294, 20);
            this.TxtEmailRespaldo.TabIndex = 9;
            this.TxtEmailRespaldo.TextChanged += new System.EventHandler(this.TxtEmailRespaldo_TextChanged);
            this.TxtEmailRespaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailRespaldo_KeyPress);
            this.TxtEmailRespaldo.Leave += new System.EventHandler(this.TxtEmailRespaldo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Correo de respaldo";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(446, 20);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(294, 20);
            this.TxtTelefono.TabIndex = 9;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(61, 125);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(239, 20);
            this.TxtCedula.TabIndex = 7;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(61, 53);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(239, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(61, 88);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(239, 20);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(61, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(239, 20);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(26, 394);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(96, 34);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(177, 394);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 34);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Coral;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(341, 394);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 34);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiarForm
            // 
            this.BtnLimpiarForm.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarForm.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarForm.Location = new System.Drawing.Point(502, 394);
            this.BtnLimpiarForm.Name = "BtnLimpiarForm";
            this.BtnLimpiarForm.Size = new System.Drawing.Size(105, 34);
            this.BtnLimpiarForm.TabIndex = 5;
            this.BtnLimpiarForm.Text = "Limpiar Formulario";
            this.BtnLimpiarForm.UseVisualStyleBackColor = false;
            this.BtnLimpiarForm.Click += new System.EventHandler(this.BtnLimpiarForm_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(680, 394);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(108, 34);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "CANCELAR";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtBuscar.Location = new System.Drawing.Point(268, 6);
            this.TxtBuscar.MaxLength = 20;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(246, 26);
            this.TxtBuscar.TabIndex = 8;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVerActivos.Location = new System.Drawing.Point(637, 11);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(151, 20);
            this.CbVerActivos.TabIndex = 9;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckStateChanged += new System.EventHandler(this.CbVerActivos_CheckStateChanged);
            // 
            // BtnVerPassword
            // 
            this.BtnVerPassword.Location = new System.Drawing.Point(693, 86);
            this.BtnVerPassword.Name = "BtnVerPassword";
            this.BtnVerPassword.Size = new System.Drawing.Size(37, 22);
            this.BtnVerPassword.TabIndex = 14;
            this.BtnVerPassword.Text = "Ver";
            this.BtnVerPassword.UseVisualStyleBackColor = true;
            this.BtnVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseDown);
            this.BtnVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseUp);
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiarForm);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaUsuarios);
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiarForm;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.ComboBox CboxTipoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmailRespaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRol;
        private System.Windows.Forms.Button BtnVerPassword;
    }
}