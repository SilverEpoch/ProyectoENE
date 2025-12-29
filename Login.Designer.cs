namespace ProyectoENE
{
    partial class Login
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
            label2 = new Label();
            label1 = new Label();
            txt_clave = new TextBox();
            txt_usuario = new TextBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            menuStrip1 = new MenuStrip();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 195);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 145);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 10;
            label1.Text = "Usuario";
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(308, 195);
            txt_clave.Margin = new Padding(3, 4, 3, 4);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(177, 27);
            txt_clave.TabIndex = 9;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(303, 141);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(177, 27);
            txt_usuario.TabIndex = 8;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(399, 252);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(86, 31);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(236, 252);
            btn_aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(86, 31);
            btn_aceptar.TabIndex = 6;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(112, 24);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            crearUsuarioToolStripMenuItem.Click += crearUsuarioToolStripMenuItem_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_clave;
        private TextBox txt_usuario;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
    }
}