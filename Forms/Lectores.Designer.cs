namespace MiBiblioteca
{
    partial class Lectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lectores));
            dataGridView1 = new DataGridView();
            nombreLector = new DataGridViewTextBoxColumn();
            dniLector = new DataGridViewTextBoxColumn();
            txtDni = new TextBox();
            txtNombreLector = new TextBox();
            lblDniLector = new Label();
            lblNombreLector = new Label();
            btnLimpiar = new Button();
            btnEliminarLector = new Button();
            btnAgregarLector = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreLector, dniLector });
            dataGridView1.Location = new Point(12, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(599, 185);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombreLector
            // 
            nombreLector.HeaderText = "Nombre Completo";
            nombreLector.Name = "nombreLector";
            nombreLector.ReadOnly = true;
            nombreLector.Width = 356;
            // 
            // dniLector
            // 
            dniLector.HeaderText = "DNI";
            dniLector.Name = "dniLector";
            dniLector.ReadOnly = true;
            dniLector.Width = 200;
            // 
            // txtDni
            // 
            txtDni.AcceptsReturn = true;
            txtDni.Location = new Point(132, 104);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(292, 23);
            txtDni.TabIndex = 15;
            // 
            // txtNombreLector
            // 
            txtNombreLector.AcceptsReturn = true;
            txtNombreLector.Location = new Point(132, 54);
            txtNombreLector.Name = "txtNombreLector";
            txtNombreLector.Size = new Size(292, 23);
            txtNombreLector.TabIndex = 14;
            // 
            // lblDniLector
            // 
            lblDniLector.AutoSize = true;
            lblDniLector.Location = new Point(19, 107);
            lblDniLector.Name = "lblDniLector";
            lblDniLector.Size = new Size(27, 15);
            lblDniLector.TabIndex = 13;
            lblDniLector.Text = "DNI";
            // 
            // lblNombreLector
            // 
            lblNombreLector.AutoSize = true;
            lblNombreLector.Location = new Point(19, 57);
            lblNombreLector.Name = "lblNombreLector";
            lblNombreLector.Size = new Size(107, 15);
            lblNombreLector.TabIndex = 12;
            lblNombreLector.Text = "Nombre Completo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(463, 157);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 53);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLector
            // 
            btnEliminarLector.Location = new Point(463, 98);
            btnEliminarLector.Name = "btnEliminarLector";
            btnEliminarLector.Size = new Size(131, 53);
            btnEliminarLector.TabIndex = 10;
            btnEliminarLector.Text = "Eliminar Lector";
            btnEliminarLector.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLector
            // 
            btnAgregarLector.Location = new Point(463, 37);
            btnAgregarLector.Name = "btnAgregarLector";
            btnAgregarLector.Size = new Size(131, 55);
            btnAgregarLector.TabIndex = 9;
            btnAgregarLector.Text = "Agregar Lector";
            btnAgregarLector.UseVisualStyleBackColor = true;
            btnAgregarLector.Click += btnAgregarLector_Click;
            // 
            // Lectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(txtDni);
            Controls.Add(txtNombreLector);
            Controls.Add(lblDniLector);
            Controls.Add(lblNombreLector);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminarLector);
            Controls.Add(btnAgregarLector);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lectores";
            Text = "Sistema Biblioteca - Gestión Lectores";
            Load += Lectores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreLector;
        private DataGridViewTextBoxColumn dniLector;
        private TextBox txtDni;
        private TextBox txtNombreLector;
        private Label lblDniLector;
        private Label lblNombreLector;
        private Button btnLimpiar;
        private Button btnEliminarLector;
        private Button btnAgregarLector;
    }
}