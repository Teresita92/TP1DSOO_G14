namespace MiBiblioteca
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            imgGrupo14 = new PictureBox();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgGrupo14).BeginInit();
            SuspendLayout();
            // 
            // imgGrupo14
            // 
            imgGrupo14.Image = (Image)resources.GetObject("imgGrupo14.Image");
            imgGrupo14.Location = new Point(32, 70);
            imgGrupo14.Name = "imgGrupo14";
            imgGrupo14.Size = new Size(161, 157);
            imgGrupo14.SizeMode = PictureBoxSizeMode.Zoom;
            imgGrupo14.TabIndex = 0;
            imgGrupo14.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(349, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 44);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(218, 153);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(242, 23);
            txtPass.TabIndex = 2;
            txtPass.Text = "Ingrese contraseña...";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "Usuario";
            txtUser.AccessibleName = "user";
            txtUser.Location = new Point(218, 94);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(242, 23);
            txtUser.TabIndex = 3;
            txtUser.Text = "Ingrese usuario...";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 129);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 311);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Controls.Add(imgGrupo14);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Sistema Biblioteca";
            ((System.ComponentModel.ISupportInitialize)imgGrupo14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgGrupo14;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
    }
}
