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
            button1 = new Button();
            button2 = new Button();
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            label1 = new Label();
            lblTipo = new Label();
            lblNumero = new Label();
            cboxTipo = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(572, 50);
            button1.Name = "button1";
            button1.Size = new Size(168, 45);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(572, 140);
            button2.Name = "button2";
            button2.Size = new Size(168, 45);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(275, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(275, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 23);
            textBox4.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(95, 39);
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
            lblApellido.Location = new Point(97, 81);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 125);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 8;
            label1.Text = "Apellido";
            label1.Click += label1_Click_2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(97, 175);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(44, 21);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(240, 175);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(29, 21);
            lblNumero.TabIndex = 10;
            lblNumero.Text = "N°";
            // 
            // cboxTipo
            // 
            cboxTipo.AutoCompleteCustomSource.AddRange(new string[] { "DNI", "Pasaporte" });
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta Cívica", "Libreta de Enrolamiento" });
            cboxTipo.Location = new Point(147, 177);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(87, 23);
            cboxTipo.TabIndex = 11;
            cboxTipo.Text = "DNI";
            // 
            // registroPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cboxTipo);
            Controls.Add(lblNumero);
            Controls.Add(lblTipo);
            Controls.Add(label1);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "registroPersona";
            Text = "Registro Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtNombre;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblNombre;
        private Label lblApellido;
        private Label label1;
        private Label lblTipo;
        private Label lblNumero;
        private ComboBox cboxTipo;
    }
}