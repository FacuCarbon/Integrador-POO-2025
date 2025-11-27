namespace Integrador.UI
{
    partial class ListadoBase
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            searchbar = new TextBox();
            boton_crear_base = new Button();
            title_listado_base = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(searchbar);
            panel1.Controls.Add(boton_crear_base);
            panel1.Controls.Add(title_listado_base);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 555);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(969, 438);
            dataGridView1.TabIndex = 9;
            // 
            // searchbar
            // 
            searchbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchbar.Location = new Point(251, 54);
            searchbar.Margin = new Padding(6, 8, 6, 6);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Buscar...";
            searchbar.Size = new Size(528, 23);
            searchbar.TabIndex = 8;
            // 
            // boton_crear_base
            // 
            boton_crear_base.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boton_crear_base.BackColor = Color.Transparent;
            boton_crear_base.BackgroundImageLayout = ImageLayout.None;
            boton_crear_base.FlatAppearance.BorderSize = 0;
            boton_crear_base.ForeColor = Color.Transparent;
            boton_crear_base.Image = Properties.Resources.Button_add;
            boton_crear_base.Location = new Point(847, 14);
            boton_crear_base.Name = "boton_crear_base";
            boton_crear_base.Size = new Size(100, 50);
            boton_crear_base.TabIndex = 7;
            boton_crear_base.UseVisualStyleBackColor = false;
            boton_crear_base.Click += Boton_crear_base_Click;
            // 
            // title_listado_base
            // 
            title_listado_base.AutoSize = true;
            title_listado_base.BackColor = Color.Transparent;
            title_listado_base.Font = new Font("Arial Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            title_listado_base.ForeColor = Color.White;
            title_listado_base.Location = new Point(17, 18);
            title_listado_base.Name = "title_listado_base";
            title_listado_base.Size = new Size(0, 33);
            title_listado_base.TabIndex = 6;
            // 
            // ListadoBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel1);
            Name = "ListadoBase";
            Size = new Size(969, 555);

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox searchbar;
        private Button boton_crear_base;
        private Label title_listado_base;
    }
}
