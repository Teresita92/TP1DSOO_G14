namespace MiBiblioteca
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            dataGridView1 = new DataGridView();
            nombreLibro = new DataGridViewTextBoxColumn();
            autorLibro = new DataGridViewTextBoxColumn();
            editorialLibro = new DataGridViewTextBoxColumn();
            btnAgregarLibro = new Button();
            btnEliminarLibro = new Button();
            btnLimpiar = new Button();
            lblNombreLibro = new Label();
            lblAutorLibro = new Label();
            txtNombreLibro = new TextBox();
            txtAutorLibro = new TextBox();
            txtEditorialLibro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreLibro, autorLibro, editorialLibro });
            dataGridView1.Location = new Point(12, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(599, 185);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombreLibro
            // 
            nombreLibro.HeaderText = "Nombre Libro";
            nombreLibro.Name = "nombreLibro";
            nombreLibro.ReadOnly = true;
            nombreLibro.Width = 200;
            // 
            // autorLibro
            // 
            autorLibro.HeaderText = "Autor";
            autorLibro.Name = "autorLibro";
            autorLibro.ReadOnly = true;
            autorLibro.Width = 200;
            // 
            // editorialLibro
            // 
            editorialLibro.HeaderText = "Editorial";
            editorialLibro.Name = "editorialLibro";
            editorialLibro.ReadOnly = true;
            editorialLibro.Width = 156;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(456, 33);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(131, 55);
            btnAgregarLibro.TabIndex = 1;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(456, 94);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(131, 53);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(456, 153);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 53);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNombreLibro
            // 
            lblNombreLibro.AutoSize = true;
            lblNombreLibro.Location = new Point(12, 53);
            lblNombreLibro.Name = "lblNombreLibro";
            lblNombreLibro.Size = new Size(97, 15);
            lblNombreLibro.TabIndex = 4;
            lblNombreLibro.Text = "Nombre de Libro";
            // 
            // lblAutorLibro
            // 
            lblAutorLibro.AutoSize = true;
            lblAutorLibro.Location = new Point(12, 103);
            lblAutorLibro.Name = "lblAutorLibro";
            lblAutorLibro.Size = new Size(83, 15);
            lblAutorLibro.TabIndex = 5;
            lblAutorLibro.Text = "Autor de Libro";
 
            // 
            // txtNombreLibro
            // 
            txtNombreLibro.AcceptsReturn = true;
            txtNombreLibro.Location = new Point(115, 50);
            txtNombreLibro.Name = "txtNombreLibro";
            txtNombreLibro.Size = new Size(292, 23);
            txtNombreLibro.TabIndex = 7;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.AcceptsReturn = true;
            txtAutorLibro.Location = new Point(115, 100);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(292, 23);
            txtAutorLibro.TabIndex = 8;
            // 
            // txtEditorialLibro
            // 
            txtEditorialLibro.AcceptsReturn = true;
            txtEditorialLibro.Location = new Point(115, 150);
            txtEditorialLibro.Name = "txtEditorialLibro";
            txtEditorialLibro.Size = new Size(292, 23);
            txtEditorialLibro.TabIndex = 9;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(txtEditorialLibro);
            Controls.Add(txtAutorLibro);
            Controls.Add(txtNombreLibro);
            Controls.Add(lblAutorLibro);
            Controls.Add(lblNombreLibro);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnAgregarLibro);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Libros";
            Text = "Sistema Biblioteca - Gestión Libros";
            Load += Libros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreLibro;
        private DataGridViewTextBoxColumn autorLibro;
        private DataGridViewTextBoxColumn editorialLibro;
        private Button btnAgregarLibro;
        private Button btnEliminarLibro;
        private Button btnLimpiar;
        private Label lblNombreLibro;
        private Label lblAutorLibro;
        private TextBox txtNombreLibro;
        private TextBox txtAutorLibro;
        private TextBox txtEditorialLibro;
    }
}