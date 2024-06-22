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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            BtnIngresar = new Button();
            TxtBUsuario = new TextBox();
            TxTBPass = new TextBox();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(491, 221);
            BtnIngresar.Margin = new Padding(3, 2, 3, 2);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(111, 42);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += button1_Click;
            // 
            // TxtBUsuario
            // 
            TxtBUsuario.BackColor = SystemColors.Window;
            TxtBUsuario.Location = new Point(366, 112);
            TxtBUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtBUsuario.Name = "TxtBUsuario";
            TxtBUsuario.Size = new Size(361, 23);
            TxtBUsuario.TabIndex = 1;
            TxtBUsuario.Text = "Usuario";
            TxtBUsuario.TextChanged += textBox1_TextChanged;
            TxtBUsuario.Enter += TxtBUsuario_Enter;
            TxtBUsuario.Leave += TxtBUsuario_Leave;
            // 
            // TxTBPass
            // 
            TxTBPass.BackColor = SystemColors.Window;
            TxTBPass.Location = new Point(366, 158);
            TxTBPass.Margin = new Padding(3, 2, 3, 2);
            TxTBPass.Name = "TxTBPass";
            TxTBPass.Size = new Size(361, 23);
            TxTBPass.TabIndex = 2;
            TxTBPass.Text = "Contraseña";
            TxTBPass.Enter += TxTBPass_Enter;
            TxTBPass.Leave += TxTBPass_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 61);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(421, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 37);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Ingreso al Sistema";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 388);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(TxTBPass);
            Controls.Add(TxtBUsuario);
            Controls.Add(BtnIngresar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_login";
            Text = "Login";
            Load += frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIngresar;
        private TextBox TxtBUsuario;
        private TextBox TxTBPass;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
};