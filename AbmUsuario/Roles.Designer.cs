namespace FrbaHotel.AbmUsuario
{
    partial class Roles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roles_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles_funcionalidades = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roles_nombre,
            this.roles_estado,
            this.roles_funcionalidades});
            this.dataGridView1.Location = new System.Drawing.Point(45, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(479, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // roles_nombre
            // 
            this.roles_nombre.HeaderText = "Nombre";
            this.roles_nombre.Name = "roles_nombre";
            // 
            // roles_estado
            // 
            this.roles_estado.HeaderText = "Estado";
            this.roles_estado.Name = "roles_estado";
            // 
            // roles_funcionalidades
            // 
            this.roles_funcionalidades.HeaderText = "Funcionalidades";
            this.roles_funcionalidades.Name = "roles_funcionalidades";
            this.roles_funcionalidades.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roles_funcionalidades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Roles";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles_estado;
        private System.Windows.Forms.DataGridViewButtonColumn roles_funcionalidades;
    }
}