namespace ProyectoENE.UI
{
    partial class EditarUsuario
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
            txt_Nombre = new TextBox();
            txt_Correo = new TextBox();
            btn_Guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(320, 119);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(125, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(320, 185);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(125, 27);
            txt_Correo.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(335, 275);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(94, 29);
            btn_Guardar.TabIndex = 2;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_aceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 122);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 66);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "Editar Usuario";
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Guardar);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nombre);
            Name = "EditarUsuario";
            Text = "EditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Correo;
        private Button btn_Guardar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}