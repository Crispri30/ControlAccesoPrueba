namespace ControlAccesoPrueba.Forms
{
    partial class Form1
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
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BttIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(148, 58);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(148, 146);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.Size = new Size(100, 23);
            TxtContraseña.TabIndex = 1;
            // 
            // BttIngresar
            // 
            BttIngresar.Location = new Point(148, 243);
            BttIngresar.Name = "BttIngresar";
            BttIngresar.Size = new Size(100, 49);
            BttIngresar.TabIndex = 2;
            BttIngresar.Text = "Ingresar";
            BttIngresar.UseVisualStyleBackColor = true;
            BttIngresar.Click += BttIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 66);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BttIngresar);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BttIngresar;
        private Label label1;
        private Label label2;
    }
}