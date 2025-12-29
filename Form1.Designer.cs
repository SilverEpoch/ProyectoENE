namespace ProyectoENE
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txt_correo = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txt_clave = new TextBox();
            txt_usuario = new TextBox();
            btn_agregar = new Button();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            verListadoToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_correo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_clave);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Location = new Point(281, 83);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(267, 295);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 146);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Correo";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(93, 142);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(125, 27);
            txt_correo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 92);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 41);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 4;
            label4.Text = "Usuario";
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(93, 92);
            txt_clave.Margin = new Padding(3, 4, 3, 4);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(114, 27);
            txt_clave.TabIndex = 2;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(93, 43);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(114, 27);
            txt_usuario.TabIndex = 1;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(93, 242);
            btn_agregar.Margin = new Padding(3, 4, 3, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(86, 31);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verListadoToolStripMenuItem, loginToolStripMenuItem1 });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(60, 24);
            loginToolStripMenuItem.Text = "Menu";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // verListadoToolStripMenuItem
            // 
            verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            verListadoToolStripMenuItem.Size = new Size(224, 26);
            verListadoToolStripMenuItem.Text = "Ver listado";
            verListadoToolStripMenuItem.Click += verListadoToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(224, 26);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private TextBox txt_clave;
        private TextBox txt_usuario;
        private Button btn_agregar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private TextBox txt_correo;
        private Label label1;
        private ToolStripMenuItem verListadoToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
    }
}
