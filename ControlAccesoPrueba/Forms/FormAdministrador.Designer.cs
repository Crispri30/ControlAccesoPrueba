namespace ControlAccesoPrueba.Forms
{
    partial class FormAdministrador
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
            cmbRol = new ComboBox();
            txtID = new TextBox();
            bttAgregar = new Button();
            txtZona = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(107, 237);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 77);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // bttAgregar
            // 
            bttAgregar.Location = new Point(107, 277);
            bttAgregar.Name = "bttAgregar";
            bttAgregar.Size = new Size(75, 23);
            bttAgregar.TabIndex = 3;
            bttAgregar.Text = "Agregar";
            bttAgregar.UseVisualStyleBackColor = true;
            bttAgregar.Click += bttAgregar_Click;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(107, 181);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(100, 23);
            txtZona.TabIndex = 4;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtZona);
            Controls.Add(bttAgregar);
            Controls.Add(txtID);
            Controls.Add(cmbRol);
            Controls.Add(txtNombre);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cmbRol;
        private TextBox txtID;
        private Button bttAgregar;
        private TextBox txtZona;
    }
}