namespace NominaControl
{
    partial class AgregarEmpleado
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
            txtNombre = new TextBox();
            cmbPuestos = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(325, 23);
            txtNombre.TabIndex = 0;
            // 
            // cmbPuestos
            // 
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(128, 69);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(122, 23);
            cmbPuestos.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 197);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(184, 105);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(269, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(184, 105);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Puesto";
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 352);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbPuestos);
            Controls.Add(txtNombre);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            Load += AgregarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cmbPuestos;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
    }
}