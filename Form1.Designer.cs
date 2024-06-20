namespace ClubDeportivo
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Ingresar = new Button();
            TxtB_Usuario = new TextBox();
            TxTB_Contraseña = new TextBox();
            pictureBox1 = new PictureBox();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Ingresar
            // 
            Btn_Ingresar.Location = new Point(506, 270);
            Btn_Ingresar.Name = "Btn_Ingresar";
            Btn_Ingresar.Size = new Size(94, 29);
            Btn_Ingresar.TabIndex = 0;
            Btn_Ingresar.Text = "Ingresar";
            Btn_Ingresar.UseVisualStyleBackColor = true;
            Btn_Ingresar.Click += button1_Click;
            // 
            // TxtB_Usuario
            // 
            TxtB_Usuario.BackColor = SystemColors.Window;
            TxtB_Usuario.Location = new Point(418, 149);
            TxtB_Usuario.Name = "TxtB_Usuario";
            TxtB_Usuario.Size = new Size(412, 27);
            TxtB_Usuario.TabIndex = 1;
            TxtB_Usuario.Text = "Usuario";
            TxtB_Usuario.TextChanged += textBox1_TextChanged;
            // 
            // TxTB_Contraseña
            // 
            TxTB_Contraseña.BackColor = SystemColors.Window;
            TxTB_Contraseña.Location = new Point(418, 210);
            TxTB_Contraseña.Name = "TxTB_Contraseña";
            TxTB_Contraseña.Size = new Size(412, 27);
            TxTB_Contraseña.TabIndex = 2;
            TxTB_Contraseña.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(64, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 333);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F);
            Titulo.Location = new Point(481, 37);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(291, 46);
            Titulo.TabIndex = 4;
            Titulo.Text = "Ingreso al Sistema";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 518);
            Controls.Add(Titulo);
            Controls.Add(pictureBox1);
            Controls.Add(TxTB_Contraseña);
            Controls.Add(TxtB_Usuario);
            Controls.Add(Btn_Ingresar);
            Name = "frm_login";
            Text = "Login";
            Load += frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Ingresar;
        private TextBox TxtB_Usuario;
        private TextBox TxTB_Contraseña;
        private PictureBox pictureBox1;
        private Label Titulo;
    }
};