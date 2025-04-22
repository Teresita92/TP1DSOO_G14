namespace MiBiblioteca
{
    partial class FormPrestarLibro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título del libro:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(110, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(250, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 45);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(82, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del lector:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(110, 42);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 23);
            txtDni.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(110, 80);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(260, 80);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPrestarLibro
            // 
            ClientSize = new Size(384, 131);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrestarLibro";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormPrestarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
