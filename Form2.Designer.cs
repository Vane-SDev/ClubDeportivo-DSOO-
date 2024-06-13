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
            lb_UsuarioLogin = new Label();
            txtB_usuarioIngresado = new TextBox();
            btn_registrar = new Button();
            btn_emitirCarnet = new Button();
            btn_cobrarCuota = new Button();
            btn_vencimiento = new Button();
            btn_salirLogin = new Button();
            SuspendLayout();
            // 
            // lb_UsuarioLogin
            // 
            lb_UsuarioLogin.AutoSize = true;
            lb_UsuarioLogin.Location = new Point(28, 9);
            lb_UsuarioLogin.Name = "lb_UsuarioLogin";
            lb_UsuarioLogin.Size = new Size(66, 20);
            lb_UsuarioLogin.TabIndex = 0;
            lb_UsuarioLogin.Text = "Usuario: ";
            // 
            // txtB_usuarioIngresado
            // 
            txtB_usuarioIngresado.Location = new Point(87, 6);
            txtB_usuarioIngresado.Name = "txtB_usuarioIngresado";
            txtB_usuarioIngresado.Size = new Size(161, 27);
            txtB_usuarioIngresado.TabIndex = 1;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(107, 139);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(265, 81);
            btn_registrar.TabIndex = 2;
            btn_registrar.Text = "Registrar Usuario";
            btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_emitirCarnet
            // 
            btn_emitirCarnet.Location = new Point(448, 139);
            btn_emitirCarnet.Name = "btn_emitirCarnet";
            btn_emitirCarnet.Size = new Size(265, 81);
            btn_emitirCarnet.TabIndex = 3;
            btn_emitirCarnet.Text = "Emitir Carnet";
            btn_emitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarCuota
            // 
            btn_cobrarCuota.Location = new Point(107, 276);
            btn_cobrarCuota.Name = "btn_cobrarCuota";
            btn_cobrarCuota.Size = new Size(265, 80);
            btn_cobrarCuota.TabIndex = 4;
            btn_cobrarCuota.Text = "Cobrar Cuota";
            btn_cobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btn_vencimiento
            // 
            btn_vencimiento.Location = new Point(448, 276);
            btn_vencimiento.Name = "btn_vencimiento";
            btn_vencimiento.Size = new Size(265, 80);
            btn_vencimiento.TabIndex = 5;
            btn_vencimiento.Text = "Vencimiento";
            btn_vencimiento.UseVisualStyleBackColor = true;
            // 
            // btn_salirLogin
            // 
            btn_salirLogin.Location = new Point(673, 5);
            btn_salirLogin.Name = "btn_salirLogin";
            btn_salirLogin.Size = new Size(94, 29);
            btn_salirLogin.TabIndex = 6;
            btn_salirLogin.Text = "Salir";
            btn_salirLogin.UseVisualStyleBackColor = true;
            // 
            // VentanaPpal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salirLogin);
            Controls.Add(btn_vencimiento);
            Controls.Add(btn_cobrarCuota);
            Controls.Add(btn_emitirCarnet);
            Controls.Add(btn_registrar);
            Controls.Add(txtB_usuarioIngresado);
            Controls.Add(lb_UsuarioLogin);
            Name = "VentanaPpal";
            Text = "Ventana Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_UsuarioLogin;
        private TextBox txtB_usuarioIngresado;
        private Button btn_registrar;
        private Button btn_emitirCarnet;
        private Button btn_cobrarCuota;
        private Button btn_vencimiento;
        private Button btn_salirLogin;
    }
}