namespace FrbaHotel.AbmHabitacion
{
    partial class ABM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alta_tipoId = new System.Windows.Forms.ComboBox();
            this.alta_apellido = new System.Windows.Forms.TextBox();
            this.alta_ubicacion = new System.Windows.Forms.TextBox();
            this.alta_descripcion = new System.Windows.Forms.TextBox();
            this.alta_numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filtro_tipo = new System.Windows.Forms.ComboBox();
            this.filtro_piso = new System.Windows.Forms.TextBox();
            this.filtro_ubicacion = new System.Windows.Forms.TextBox();
            this.filtro_descripcion = new System.Windows.Forms.TextBox();
            this.filtro_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabla_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 657);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1057, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alta_tipoId);
            this.groupBox1.Controls.Add(this.alta_apellido);
            this.groupBox1.Controls.Add(this.alta_ubicacion);
            this.groupBox1.Controls.Add(this.alta_descripcion);
            this.groupBox1.Controls.Add(this.alta_numero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 257);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos basicos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // alta_tipoId
            // 
            this.alta_tipoId.FormattingEnabled = true;
            this.alta_tipoId.Location = new System.Drawing.Point(571, 114);
            this.alta_tipoId.Margin = new System.Windows.Forms.Padding(4);
            this.alta_tipoId.Name = "alta_tipoId";
            this.alta_tipoId.Size = new System.Drawing.Size(252, 24);
            this.alta_tipoId.TabIndex = 12;
            // 
            // alta_apellido
            // 
            this.alta_apellido.Location = new System.Drawing.Point(571, 69);
            this.alta_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.alta_apellido.Name = "alta_apellido";
            this.alta_apellido.Size = new System.Drawing.Size(252, 22);
            this.alta_apellido.TabIndex = 11;
            // 
            // alta_ubicacion
            // 
            this.alta_ubicacion.Location = new System.Drawing.Point(111, 112);
            this.alta_ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.alta_ubicacion.Name = "alta_ubicacion";
            this.alta_ubicacion.Size = new System.Drawing.Size(299, 22);
            this.alta_ubicacion.TabIndex = 11;
            // 
            // alta_descripcion
            // 
            this.alta_descripcion.Location = new System.Drawing.Point(111, 160);
            this.alta_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.alta_descripcion.Name = "alta_descripcion";
            this.alta_descripcion.Size = new System.Drawing.Size(299, 22);
            this.alta_descripcion.TabIndex = 11;
            // 
            // alta_numero
            // 
            this.alta_numero.Location = new System.Drawing.Point(111, 65);
            this.alta_numero.Margin = new System.Windows.Forms.Padding(4);
            this.alta_numero.Name = "alta_numero";
            this.alta_numero.Size = new System.Drawing.Size(299, 22);
            this.alta_numero.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label8.Location = new System.Drawing.Point(491, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label3.Location = new System.Drawing.Point(491, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Piso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ubicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baja/Modificacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabla_numero,
            this.tabla_piso,
            this.tabla_ubicacion,
            this.tabla_tipo,
            this.tabla_descripcion,
            this.modificar,
            this.eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(67, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filtro_tipo);
            this.groupBox2.Controls.Add(this.filtro_piso);
            this.groupBox2.Controls.Add(this.filtro_ubicacion);
            this.groupBox2.Controls.Add(this.filtro_descripcion);
            this.groupBox2.Controls.Add(this.filtro_numero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(61, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(921, 267);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // filtro_tipo
            // 
            this.filtro_tipo.FormattingEnabled = true;
            this.filtro_tipo.Location = new System.Drawing.Point(608, 124);
            this.filtro_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_tipo.Name = "filtro_tipo";
            this.filtro_tipo.Size = new System.Drawing.Size(252, 24);
            this.filtro_tipo.TabIndex = 34;
            // 
            // filtro_piso
            // 
            this.filtro_piso.Location = new System.Drawing.Point(608, 79);
            this.filtro_piso.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_piso.Name = "filtro_piso";
            this.filtro_piso.Size = new System.Drawing.Size(252, 22);
            this.filtro_piso.TabIndex = 30;
            // 
            // filtro_ubicacion
            // 
            this.filtro_ubicacion.Location = new System.Drawing.Point(148, 122);
            this.filtro_ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_ubicacion.Name = "filtro_ubicacion";
            this.filtro_ubicacion.Size = new System.Drawing.Size(299, 22);
            this.filtro_ubicacion.TabIndex = 31;
            // 
            // filtro_descripcion
            // 
            this.filtro_descripcion.Location = new System.Drawing.Point(148, 170);
            this.filtro_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_descripcion.Name = "filtro_descripcion";
            this.filtro_descripcion.Size = new System.Drawing.Size(299, 22);
            this.filtro_descripcion.TabIndex = 32;
            // 
            // filtro_numero
            // 
            this.filtro_numero.Location = new System.Drawing.Point(148, 75);
            this.filtro_numero.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_numero.Name = "filtro_numero";
            this.filtro_numero.Size = new System.Drawing.Size(299, 22);
            this.filtro_numero.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label2.Location = new System.Drawing.Point(528, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label5.Location = new System.Drawing.Point(528, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ubicacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Numero";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 219);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(796, 219);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabla_numero
            // 
            this.tabla_numero.HeaderText = "Numero";
            this.tabla_numero.Name = "tabla_numero";
            // 
            // tabla_piso
            // 
            this.tabla_piso.HeaderText = "Piso";
            this.tabla_piso.Name = "tabla_piso";
            // 
            // tabla_ubicacion
            // 
            this.tabla_ubicacion.HeaderText = "Ubicacion";
            this.tabla_ubicacion.Name = "tabla_ubicacion";
            // 
            // tabla_tipo
            // 
            this.tabla_tipo.HeaderText = "Tipo";
            this.tabla_tipo.Name = "tabla_tipo";
            // 
            // tabla_descripcion
            // 
            this.tabla_descripcion.HeaderText = "Descripcion";
            this.tabla_descripcion.Name = "tabla_descripcion";
            // 
            // modificar
            // 
            this.modificar.HeaderText = "Modificar";
            this.modificar.Name = "modificar";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1092, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "ABM";
            this.Text = "ABM HABITACION";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox alta_tipoId;
        private System.Windows.Forms.TextBox alta_apellido;
        private System.Windows.Forms.TextBox alta_ubicacion;
        private System.Windows.Forms.TextBox alta_descripcion;
        private System.Windows.Forms.TextBox alta_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox filtro_tipo;
        private System.Windows.Forms.TextBox filtro_piso;
        private System.Windows.Forms.TextBox filtro_ubicacion;
        private System.Windows.Forms.TextBox filtro_descripcion;
        private System.Windows.Forms.TextBox filtro_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn modificar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}