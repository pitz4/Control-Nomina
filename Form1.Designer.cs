namespace NominaControl
{
    partial class Form1
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
            lstEmpleados = new ListBox();
            btnAgregarEmpleado = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(12, 12);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(374, 94);
            lstEmpleados.TabIndex = 0;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(106, 182);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(169, 79);
            btnAgregarEmpleado.TabIndex = 1;
            btnAgregarEmpleado.Text = "Agregar empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(106, 267);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 78);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(lstEmpleados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }




        #endregion

        private ListBox lstEmpleados;
        private Button btnAgregarEmpleado;
        private Button btnEliminar;
    }
}