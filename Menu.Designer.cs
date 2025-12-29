namespace ProyectoENE
{
    partial class Menu
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
            button4 = new Button();
            btn_Registrar_Usuario = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(338, 328);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btn_Registrar_Usuario
            // 
            btn_Registrar_Usuario.Location = new Point(307, 177);
            btn_Registrar_Usuario.Name = "btn_Registrar_Usuario";
            btn_Registrar_Usuario.Size = new Size(160, 29);
            btn_Registrar_Usuario.TabIndex = 4;
            btn_Registrar_Usuario.Text = "Registrar Usuario";
            btn_Registrar_Usuario.UseVisualStyleBackColor = true;
            btn_Registrar_Usuario.Click += btn_Registrar_Usuario_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Registrar_Usuario);
            Controls.Add(button4);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button btn_Registrar_Usuario;
    }
}