namespace ClubDeportivo
{
    partial class registroPersona
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
            btnRegistrar = new Button();
            btnBorrar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumero = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblNumero = new Label();
            cboxTipo = new ComboBox();
            chkAptoFisico = new CheckBox();
            lblCondicion = new Label();
            rdbtnSocio = new RadioButton();
            radbtnNoSocio = new RadioButton();
            dtgvRegistro = new DataGridView();
            idRegistro = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            AptoFisico = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(572, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(168, 45);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(572, 81);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(168, 45);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(275, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre";
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(275, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(197, 23);
            txtApellido.TabIndex = 4;
            txtApellido.Text = "Apellido";
            txtApellido.TextChanged += textBox3_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(275, 125);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(197, 23);
            txtNumero.TabIndex = 5;
            txtNumero.Text = "99999999";
            txtNumero.TextChanged += textBox4_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(64, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre ";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(64, 81);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label1_Click_1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(64, 123);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(44, 21);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(240, 123);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(29, 21);
            lblNumero.TabIndex = 10;
            lblNumero.Text = "N°";
            // 
            // cboxTipo
            // 
            cboxTipo.AutoCompleteCustomSource.AddRange(new string[] { "DNI", "Pasaporte" });
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta Cívica" });
            cboxTipo.Location = new Point(128, 125);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(87, 23);
            cboxTipo.TabIndex = 11;
            cboxTipo.Text = "DNI";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.CheckAlign = ContentAlignment.MiddleRight;
            chkAptoFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAptoFisico.Location = new Point(73, 175);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(113, 25);
            chkAptoFisico.TabIndex = 12;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            chkAptoFisico.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCondicion.Location = new Point(262, 179);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(88, 21);
            lblCondicion.TabIndex = 13;
            lblCondicion.Text = "Condición";
            // 
            // rdbtnSocio
            // 
            rdbtnSocio.AutoSize = true;
            rdbtnSocio.Checked = true;
            rdbtnSocio.Location = new Point(368, 163);
            rdbtnSocio.Name = "rdbtnSocio";
            rdbtnSocio.Size = new Size(60, 19);
            rdbtnSocio.TabIndex = 14;
            rdbtnSocio.TabStop = true;
            rdbtnSocio.Text = "SOCIO";
            rdbtnSocio.UseVisualStyleBackColor = true;
            rdbtnSocio.CheckedChanged += rdbtnSocio_CheckedChanged;
            // 
            // radbtnNoSocio
            // 
            radbtnNoSocio.AutoSize = true;
            radbtnNoSocio.Location = new Point(368, 188);
            radbtnNoSocio.Name = "radbtnNoSocio";
            radbtnNoSocio.Size = new Size(81, 19);
            radbtnNoSocio.TabIndex = 15;
            radbtnNoSocio.Text = "NO SOCIO";
            radbtnNoSocio.UseVisualStyleBackColor = true;
            radbtnNoSocio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dtgvRegistro
            // 
            dtgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRegistro.Columns.AddRange(new DataGridViewColumn[] { idRegistro, Nombre, Apellido, Tipo, Numero, AptoFisico, Condicion });
            dtgvRegistro.Location = new Point(36, 233);
            dtgvRegistro.Name = "dtgvRegistro";
            dtgvRegistro.Size = new Size(738, 155);
            dtgvRegistro.TabIndex = 16;
            dtgvRegistro.CellContentClick += dtgvRegistro_CellContentClick;
            // 
            // idRegistro
            // 
            idRegistro.HeaderText = "Id Registro";
            idRegistro.Name = "idRegistro";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            // 
            // AptoFisico
            // 
            AptoFisico.HeaderText = "Apto Fisico";
            AptoFisico.Name = "AptoFisico";
            // 
            // Condicion
            // 
            Condicion.HeaderText = "Condicion";
            Condicion.Name = "Condicion";
            // 
            // btVolver
            // 
            btVolver.Location = new Point(572, 150);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(168, 45);
            btVolver.TabIndex = 17;
            btVolver.Text = "VOLVER";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += button1_Click_1;
            // 
            // registroPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btVolver);
            Controls.Add(dtgvRegistro);
            Controls.Add(radbtnNoSocio);
            Controls.Add(rdbtnSocio);
            Controls.Add(lblCondicion);
            Controls.Add(chkAptoFisico);
            Controls.Add(cboxTipo);
            Controls.Add(lblNumero);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNumero);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnBorrar);
            Controls.Add(btnRegistrar);
            Name = "registroPersona";
            RightToLeft = RightToLeft.No;
            Text = "Registro Persona";
            Load += registroPersona_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnBorrar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumero;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblNumero;
        private ComboBox cboxTipo;
        private CheckBox chkAptoFisico;
        private Label lblCondicion;
        private RadioButton rdbtnSocio;
        private RadioButton radbtnNoSocio;
        private DataGridView dtgvRegistro;
        private DataGridViewTextBoxColumn idRegistro;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn AptoFisico;
        private DataGridViewTextBoxColumn Condicion;
        private Button btVolver;
    }
}