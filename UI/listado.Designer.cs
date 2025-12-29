namespace ProyectoENE.UI
{
    partial class listado
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
            label1 = new Label();
            label2 = new Label();
            txt_buscado = new TextBox();
            cmb_criterio = new ComboBox();
            dgv_busqueda = new DataGridView();
            btn_Editar = new Button();
            lbl_id = new Label();
            label4 = new Label();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_busqueda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 78);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor Buscado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 78);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Criterio";
            // 
            // txt_buscado
            // 
            txt_buscado.Location = new Point(213, 104);
            txt_buscado.Name = "txt_buscado";
            txt_buscado.Size = new Size(125, 27);
            txt_buscado.TabIndex = 2;
            txt_buscado.TextChanged += txt_buscado_TextChanged;
            // 
            // cmb_criterio
            // 
            cmb_criterio.FormattingEnabled = true;
            cmb_criterio.Items.AddRange(new object[] { "id", "nombre", "correo" });
            cmb_criterio.Location = new Point(404, 104);
            cmb_criterio.Name = "cmb_criterio";
            cmb_criterio.Size = new Size(151, 28);
            cmb_criterio.TabIndex = 3;
            cmb_criterio.SelectedIndexChanged += cmb_criterio_SelectedIndexChanged;
            // 
            // dgv_busqueda
            // 
            dgv_busqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_busqueda.Location = new Point(163, 149);
            dgv_busqueda.Name = "dgv_busqueda";
            dgv_busqueda.RowHeadersWidth = 51;
            dgv_busqueda.Size = new Size(450, 188);
            dgv_busqueda.TabIndex = 4;
            dgv_busqueda.SelectionChanged += dgv_busqueda_SelectionChanged;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(442, 358);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(113, 40);
            btn_Editar.TabIndex = 5;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(360, 33);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(0, 20);
            lbl_id.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 33);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(313, 358);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(113, 40);
            btn_eliminar.TabIndex = 8;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // listado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eliminar);
            Controls.Add(label4);
            Controls.Add(lbl_id);
            Controls.Add(btn_Editar);
            Controls.Add(dgv_busqueda);
            Controls.Add(cmb_criterio);
            Controls.Add(txt_buscado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "listado";
            Text = "listado";
            ((System.ComponentModel.ISupportInitialize)dgv_busqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_buscado;
        private ComboBox cmb_criterio;
        private DataGridView dgv_busqueda;
        private Button btn_Editar;
        private Label lbl_id;
        private Label label4;
        private Button btn_eliminar;
    }
}