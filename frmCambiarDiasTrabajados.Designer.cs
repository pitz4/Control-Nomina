namespace NominaControl
{
    partial class frmCambiarDiasTrabajados
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.nmrDias = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(192, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(179, 41);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(192, 23);
            this.txtPuesto.TabIndex = 1;
            // 
            // nmrDias
            // 
            this.nmrDias.Location = new System.Drawing.Point(179, 70);
            this.nmrDias.Name = "nmrDias";
            this.nmrDias.Size = new System.Drawing.Size(192, 23);
            this.nmrDias.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 140);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 46);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(115, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dias trabajados";
            // 
            // frmCambiarDiasTrabajados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nmrDias);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmCambiarDiasTrabajados";
            this.Text = "frmCambiarDiasTrabajados";
            this.Load += new System.EventHandler(this.frmCambiarDiasTrabajados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPuesto;
        private NumericUpDown nmrDias;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}