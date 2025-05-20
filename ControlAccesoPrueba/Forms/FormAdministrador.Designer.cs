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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bttEliminar = new Button();
            bttActualizar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtIDVis = new TextBox();
            txtNombreVis = new TextBox();
            txtTelefono = new TextBox();
            txtMotivoVisita = new TextBox();
            bttAgregarVis = new Button();
            bttActualizarVis = new Button();
            bttEliminarVis = new Button();
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
            bttAgregar.Location = new Point(36, 293);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 80);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Identificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 135);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 189);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Zona";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 245);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(24, 15);
            label4.TabIndex = 8;
            label4.Text = "Rol";
            // 
            // bttEliminar
            // 
            bttEliminar.Location = new Point(107, 334);
            bttEliminar.Name = "bttEliminar";
            bttEliminar.Size = new Size(75, 23);
            bttEliminar.TabIndex = 9;
            bttEliminar.Text = "Eliminar";
            bttEliminar.UseVisualStyleBackColor = true;
            bttEliminar.Click += bttEliminar_Click;
            // 
            // bttActualizar
            // 
            bttActualizar.Location = new Point(153, 293);
            bttActualizar.Name = "bttActualizar";
            bttActualizar.Size = new Size(75, 23);
            bttActualizar.TabIndex = 10;
            bttActualizar.Text = "Actualizar";
            bttActualizar.UseVisualStyleBackColor = true;
            bttActualizar.Click += bttActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 27);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 11;
            label5.Text = "Gestionar Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 27);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 12;
            label6.Text = "Gestionar Visitantes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 77);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 13;
            label7.Text = "Identificación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 135);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(413, 181);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(53, 15);
            label9.TabIndex = 15;
            label9.Text = "Telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(413, 237);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(76, 15);
            label10.TabIndex = 16;
            label10.Text = "Motivo Visita";
            // 
            // txtIDVis
            // 
            txtIDVis.Location = new Point(534, 72);
            txtIDVis.Name = "txtIDVis";
            txtIDVis.Size = new Size(100, 23);
            txtIDVis.TabIndex = 17;
            // 
            // txtNombreVis
            // 
            txtNombreVis.Location = new Point(534, 127);
            txtNombreVis.Name = "txtNombreVis";
            txtNombreVis.Size = new Size(100, 23);
            txtNombreVis.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(534, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 19;
            // 
            // txtMotivoVisita
            // 
            txtMotivoVisita.Location = new Point(534, 234);
            txtMotivoVisita.Name = "txtMotivoVisita";
            txtMotivoVisita.Size = new Size(100, 23);
            txtMotivoVisita.TabIndex = 20;
            // 
            // bttAgregarVis
            // 
            bttAgregarVis.Location = new Point(475, 293);
            bttAgregarVis.Name = "bttAgregarVis";
            bttAgregarVis.Size = new Size(75, 23);
            bttAgregarVis.TabIndex = 21;
            bttAgregarVis.Text = "Agregar";
            bttAgregarVis.UseVisualStyleBackColor = true;
            bttAgregarVis.Click += bttAgregarVis_Click;
            // 
            // bttActualizarVis
            // 
            bttActualizarVis.Location = new Point(593, 293);
            bttActualizarVis.Name = "bttActualizarVis";
            bttActualizarVis.Size = new Size(75, 23);
            bttActualizarVis.TabIndex = 22;
            bttActualizarVis.Text = "Actualizar";
            bttActualizarVis.UseVisualStyleBackColor = true;
            bttActualizarVis.Click += bttActualizarVis_Click;
            // 
            // bttEliminarVis
            // 
            bttEliminarVis.Location = new Point(534, 334);
            bttEliminarVis.Name = "bttEliminarVis";
            bttEliminarVis.Size = new Size(75, 23);
            bttEliminarVis.TabIndex = 23;
            bttEliminarVis.Text = "Eliminar";
            bttEliminarVis.UseVisualStyleBackColor = true;
            bttEliminarVis.Click += bttEliminarVis_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttEliminarVis);
            Controls.Add(bttActualizarVis);
            Controls.Add(bttAgregarVis);
            Controls.Add(txtMotivoVisita);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreVis);
            Controls.Add(txtIDVis);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(bttActualizar);
            Controls.Add(bttEliminar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bttEliminar;
        private Button bttActualizar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtIDVis;
        private TextBox txtNombreVis;
        private TextBox txtTelefono;
        private TextBox txtMotivoVisita;
        private Button bttAgregarVis;
        private Button bttActualizarVis;
        private Button bttEliminarVis;
    }
}