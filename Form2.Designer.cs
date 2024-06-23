namespace ClubDeportivo
{
    partial class VentanaPpal
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
            lbl_Ingreso = new Label();
            btn_registrar = new Button();
            btn_emitirCarnet = new Button();
            btn_cobrarCuota = new Button();
            btn_vencimiento = new Button();
            btn_salirLogin = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // lbl_Ingreso
            // 
            lbl_Ingreso.AutoSize = true;
            lbl_Ingreso.Location = new Point(24, 7);
            lbl_Ingreso.Name = "lbl_Ingreso";
            lbl_Ingreso.Size = new Size(0, 15);
            lbl_Ingreso.TabIndex = 0;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(94, 104);
            btn_registrar.Margin = new Padding(3, 2, 3, 2);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(232, 61);
            btn_registrar.TabIndex = 2;
            btn_registrar.Text = "Registrar Usuario";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_emitirCarnet
            // 
            btn_emitirCarnet.Location = new Point(392, 104);
            btn_emitirCarnet.Margin = new Padding(3, 2, 3, 2);
            btn_emitirCarnet.Name = "btn_emitirCarnet";
            btn_emitirCarnet.Size = new Size(232, 61);
            btn_emitirCarnet.TabIndex = 3;
            btn_emitirCarnet.Text = "Emitir Carnet";
            btn_emitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarCuota
            // 
            btn_cobrarCuota.Location = new Point(94, 207);
            btn_cobrarCuota.Margin = new Padding(3, 2, 3, 2);
            btn_cobrarCuota.Name = "btn_cobrarCuota";
            btn_cobrarCuota.Size = new Size(232, 60);
            btn_cobrarCuota.TabIndex = 4;
            btn_cobrarCuota.Text = "Cobrar Cuota";
            btn_cobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btn_vencimiento
            // 
            btn_vencimiento.Location = new Point(392, 207);
            btn_vencimiento.Margin = new Padding(3, 2, 3, 2);
            btn_vencimiento.Name = "btn_vencimiento";
            btn_vencimiento.Size = new Size(232, 60);
            btn_vencimiento.TabIndex = 5;
            btn_vencimiento.Text = "Vencimiento";
            btn_vencimiento.UseVisualStyleBackColor = true;
            // 
            // btn_salirLogin
            // 
            btn_salirLogin.Location = new Point(589, 4);
            btn_salirLogin.Margin = new Padding(3, 2, 3, 2);
            btn_salirLogin.Name = "btn_salirLogin";
            btn_salirLogin.Size = new Size(82, 22);
            btn_salirLogin.TabIndex = 6;
            btn_salirLogin.Text = "Salir";
            btn_salirLogin.UseVisualStyleBackColor = true;
            btn_salirLogin.Click += btn_salirLogin_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(83, 7);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 15);
            lblIngreso.TabIndex = 7;
            // 
            // VentanaPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblIngreso);
            Controls.Add(btn_salirLogin);
            Controls.Add(btn_vencimiento);
            Controls.Add(btn_cobrarCuota);
            Controls.Add(btn_emitirCarnet);
            Controls.Add(btn_registrar);
            Controls.Add(lbl_Ingreso);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentanaPpal";
            Text = "Ventana Principal";
            Load += VentanaPpal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Ingreso;
        private Button btn_registrar;
        private Button btn_emitirCarnet;
        private Button btn_cobrarCuota;
        private Button btn_vencimiento;
        private Button btn_salirLogin;
        private Label lblIngreso;
    }
}