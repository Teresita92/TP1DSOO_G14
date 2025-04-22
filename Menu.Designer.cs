namespace MiBiblioteca
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDeslog = new Button();
            txtBuscarLibro = new TextBox();
            txtBuscarLector = new TextBox();
            btnBuscarLibro = new Button();
            btnBuscarLector = new Button();
            PrestarLibro = new Button();
            btnListarLibros = new Button();
            btnListarLectores = new Button();
            btnGestionarLector = new Button();
            btnGestionarLibros = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(302, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Enabled = false;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(527, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(214, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnDeslog
            // 
            btnDeslog.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeslog.Location = new Point(576, 333);
            btnDeslog.Name = "btnDeslog";
            btnDeslog.Size = new Size(167, 56);
            btnDeslog.TabIndex = 3;
            btnDeslog.Text = "CERRAR SESIÓN";
            btnDeslog.UseVisualStyleBackColor = true;
            btnDeslog.Click += btnDeslog_Click;
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.BackColor = Color.White;
            txtBuscarLibro.ForeColor = SystemColors.ScrollBar;
            txtBuscarLibro.Location = new Point(64, 211);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(100, 23);
            txtBuscarLibro.TabIndex = 4;
            txtBuscarLibro.Text = "Buscar Libro...";
            txtBuscarLibro.Enter += txtBuscarLibro_Enter;
            txtBuscarLibro.Leave += txtBuscarLibro_Leave;
            // 
            // txtBuscarLector
            // 
            txtBuscarLector.BackColor = Color.White;
            txtBuscarLector.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarLector.ForeColor = SystemColors.ScrollBar;
            txtBuscarLector.Location = new Point(302, 211);
            txtBuscarLector.Name = "txtBuscarLector";
            txtBuscarLector.Size = new Size(100, 23);
            txtBuscarLector.TabIndex = 5;
            txtBuscarLector.Text = "Buscar Lector...";
            txtBuscarLector.Enter += txtBuscarLector_Enter;
            txtBuscarLector.Leave += txtBuscarLector_Leave;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.Location = new Point(163, 210);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(30, 25);
            btnBuscarLibro.TabIndex = 6;
            btnBuscarLibro.Text = "🔎";
            btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLector
            // 
            btnBuscarLector.Location = new Point(401, 210);
            btnBuscarLector.Name = "btnBuscarLector";
            btnBuscarLector.Size = new Size(30, 25);
            btnBuscarLector.TabIndex = 7;
            btnBuscarLector.Text = "🔎";
            btnBuscarLector.UseVisualStyleBackColor = true;
            // 
            // PrestarLibro
            // 
            PrestarLibro.Location = new Point(63, 332);
            PrestarLibro.Name = "PrestarLibro";
            PrestarLibro.Size = new Size(129, 26);
            PrestarLibro.TabIndex = 11;
            PrestarLibro.Text = "Prestar Libro";
            PrestarLibro.UseVisualStyleBackColor = true;
            // 
            // btnListarLibros
            // 
            btnListarLibros.Location = new Point(63, 290);
            btnListarLibros.Name = "btnListarLibros";
            btnListarLibros.Size = new Size(129, 26);
            btnListarLibros.TabIndex = 10;
            btnListarLibros.Text = "Listar Libros";
            btnListarLibros.UseVisualStyleBackColor = true;
            // 
            // btnListarLectores
            // 
            btnListarLectores.Location = new Point(302, 290);
            btnListarLectores.Name = "btnListarLectores";
            btnListarLectores.Size = new Size(129, 26);
            btnListarLectores.TabIndex = 14;
            btnListarLectores.Text = "Listar Lectores";
            btnListarLectores.UseVisualStyleBackColor = true;
            // 
            // btnGestionarLector
            // 
            btnGestionarLector.Location = new Point(301, 249);
            btnGestionarLector.Name = "btnGestionarLector";
            btnGestionarLector.Size = new Size(129, 26);
            btnGestionarLector.TabIndex = 12;
            btnGestionarLector.Text = "Gestión Lectores";
            btnGestionarLector.UseVisualStyleBackColor = true;
            btnGestionarLector.Click += btnGestionarLector_Click;
            // 
            // btnGestionarLibros
            // 
            btnGestionarLibros.Location = new Point(63, 249);
            btnGestionarLibros.Name = "btnGestionarLibros";
            btnGestionarLibros.Size = new Size(129, 26);
            btnGestionarLibros.TabIndex = 15;
            btnGestionarLibros.Text = "Gestión Libros";
            btnGestionarLibros.UseVisualStyleBackColor = true;
            btnGestionarLibros.Click += btnGestionarLibros_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarLibros);
            Controls.Add(pictureBox3);
            Controls.Add(txtBuscarLector);
            Controls.Add(txtBuscarLibro);
            Controls.Add(btnListarLectores);
            Controls.Add(btnGestionarLector);
            Controls.Add(PrestarLibro);
            Controls.Add(btnListarLibros);
            Controls.Add(btnBuscarLector);
            Controls.Add(btnBuscarLibro);
            Controls.Add(btnDeslog);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Sistema Biblioteca";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnDeslog;
        private TextBox txtBuscarLibro;
        private TextBox txtBuscarLector;
        private Button btnBuscarLibro;
        private Button btnBuscarLector;
        private Button btnGestionLibro;
        private Button btnEliminarLibro;
        private Button PrestarLibro;
        private Button btnListarLibros;
        private Button btnListarLectores;
        private Button btnEliminarLector;
        private Button btnGestionarLector;
        private Button btnGestionarLibros;
    }
}