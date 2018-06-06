namespace FrbaHotel.AbmCliente
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
            this.alta_password = new System.Windows.Forms.TextBox();
            this.alta_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.alta_roles = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.alta_mail = new System.Windows.Forms.TextBox();
            this.alta_nombre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.alta_telefono = new System.Windows.Forms.TextBox();
            this.alta_direccion = new System.Windows.Forms.TextBox();
            this.alta_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.alta_hotel = new System.Windows.Forms.ComboBox();
            this.filtro_roles = new System.Windows.Forms.CheckedListBox();
            this.filtro_documento = new System.Windows.Forms.TextBox();
            this.filtro_usuario = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filtro_hotel = new System.Windows.Forms.ComboBox();
            this.filtro_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.filtro_direccion = new System.Windows.Forms.TextBox();
            this.filtro_mail = new System.Windows.Forms.TextBox();
            this.filtro_telefono = new System.Windows.Forms.TextBox();
            this.filtro_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabla_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_roles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabla_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talba_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.alta_documento = new System.Windows.Forms.TextBox();
            this.alta_tipo = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
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
            this.groupBox1.Controls.Add(this.alta_roles);
            this.groupBox1.Controls.Add(this.alta_password);
            this.groupBox1.Controls.Add(this.alta_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 237);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos usuario";
            // 
            // alta_password
            // 
            this.alta_password.Location = new System.Drawing.Point(571, 69);
            this.alta_password.Margin = new System.Windows.Forms.Padding(4);
            this.alta_password.Name = "alta_password";
            this.alta_password.Size = new System.Drawing.Size(252, 22);
            this.alta_password.TabIndex = 11;
            // 
            // alta_usuario
            // 
            this.alta_usuario.Location = new System.Drawing.Point(111, 65);
            this.alta_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.alta_usuario.Name = "alta_usuario";
            this.alta_usuario.Size = new System.Drawing.Size(299, 22);
            this.alta_usuario.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label3.Location = new System.Drawing.Point(491, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rol";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 571);
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
            this.tabla_usuario,
            this.tabla_roles,
            this.tabla_nombre,
            this.tabla_documento,
            this.tabla_tipo,
            this.tabla_mail,
            this.tabla_telefono,
            this.tabla_direccion,
            this.talba_nacimiento,
            this.tabla_hotel,
            this.modificar,
            this.eliminar});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(22, 300);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1013, 299);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.filtro_hotel);
            this.groupBox2.Controls.Add(this.filtro_nacimiento);
            this.groupBox2.Controls.Add(this.filtro_direccion);
            this.groupBox2.Controls.Add(this.filtro_mail);
            this.groupBox2.Controls.Add(this.filtro_telefono);
            this.groupBox2.Controls.Add(this.filtro_nombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.filtro_roles);
            this.groupBox2.Controls.Add(this.filtro_documento);
            this.groupBox2.Controls.Add(this.filtro_usuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(61, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(921, 249);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 203);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(791, 203);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // alta_roles
            // 
            this.alta_roles.FormattingEnabled = true;
            this.alta_roles.Location = new System.Drawing.Point(111, 112);
            this.alta_roles.Name = "alta_roles";
            this.alta_roles.Size = new System.Drawing.Size(299, 89);
            this.alta_roles.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.alta_tipo);
            this.groupBox3.Controls.Add(this.alta_hotel);
            this.groupBox3.Controls.Add(this.alta_nacimiento);
            this.groupBox3.Controls.Add(this.alta_direccion);
            this.groupBox3.Controls.Add(this.alta_mail);
            this.groupBox3.Controls.Add(this.alta_documento);
            this.groupBox3.Controls.Add(this.alta_telefono);
            this.groupBox3.Controls.Add(this.alta_nombre);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(52, 298);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(893, 254);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos persona";
            // 
            // alta_mail
            // 
            this.alta_mail.Location = new System.Drawing.Point(571, 69);
            this.alta_mail.Margin = new System.Windows.Forms.Padding(4);
            this.alta_mail.Name = "alta_mail";
            this.alta_mail.Size = new System.Drawing.Size(252, 22);
            this.alta_mail.TabIndex = 11;
            // 
            // alta_nombre
            // 
            this.alta_nombre.Location = new System.Drawing.Point(111, 65);
            this.alta_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.alta_nombre.Name = "alta_nombre";
            this.alta_nombre.Size = new System.Drawing.Size(299, 22);
            this.alta_nombre.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label20.Location = new System.Drawing.Point(491, 209);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "Hotel";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label21.Location = new System.Drawing.Point(491, 161);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "Direccion";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label24.Location = new System.Drawing.Point(491, 69);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 17);
            this.label24.TabIndex = 8;
            this.label24.Text = "Mail";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 205);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 17);
            this.label25.TabIndex = 10;
            this.label25.Text = "Nacimiento";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(24, 157);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 17);
            this.label26.TabIndex = 10;
            this.label26.Text = "Telefono";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(24, 65);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 17);
            this.label27.TabIndex = 10;
            this.label27.Text = "Nombre";
            // 
            // alta_telefono
            // 
            this.alta_telefono.Location = new System.Drawing.Point(111, 152);
            this.alta_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.alta_telefono.Name = "alta_telefono";
            this.alta_telefono.Size = new System.Drawing.Size(299, 22);
            this.alta_telefono.TabIndex = 11;
            // 
            // alta_direccion
            // 
            this.alta_direccion.Location = new System.Drawing.Point(571, 154);
            this.alta_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.alta_direccion.Name = "alta_direccion";
            this.alta_direccion.Size = new System.Drawing.Size(252, 22);
            this.alta_direccion.TabIndex = 11;
            // 
            // alta_nacimiento
            // 
            this.alta_nacimiento.Location = new System.Drawing.Point(111, 205);
            this.alta_nacimiento.Name = "alta_nacimiento";
            this.alta_nacimiento.Size = new System.Drawing.Size(299, 22);
            this.alta_nacimiento.TabIndex = 12;
            // 
            // alta_hotel
            // 
            this.alta_hotel.FormattingEnabled = true;
            this.alta_hotel.Location = new System.Drawing.Point(570, 205);
            this.alta_hotel.Name = "alta_hotel";
            this.alta_hotel.Size = new System.Drawing.Size(253, 24);
            this.alta_hotel.TabIndex = 13;
            // 
            // filtro_roles
            // 
            this.filtro_roles.FormattingEnabled = true;
            this.filtro_roles.Location = new System.Drawing.Point(651, 34);
            this.filtro_roles.Name = "filtro_roles";
            this.filtro_roles.Size = new System.Drawing.Size(245, 55);
            this.filtro_roles.TabIndex = 30;
            // 
            // filtro_documento
            // 
            this.filtro_documento.Location = new System.Drawing.Point(320, 34);
            this.filtro_documento.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_documento.Name = "filtro_documento";
            this.filtro_documento.Size = new System.Drawing.Size(112, 22);
            this.filtro_documento.TabIndex = 28;
            // 
            // filtro_usuario
            // 
            this.filtro_usuario.Location = new System.Drawing.Point(95, 34);
            this.filtro_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_usuario.Name = "filtro_usuario";
            this.filtro_usuario.Size = new System.Drawing.Size(159, 22);
            this.filtro_usuario.TabIndex = 29;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label.Location = new System.Drawing.Point(279, 34);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 25;
            this.label.Text = "Doc.";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Usuario";
            // 
            // filtro_hotel
            // 
            this.filtro_hotel.FormattingEnabled = true;
            this.filtro_hotel.Location = new System.Drawing.Point(360, 149);
            this.filtro_hotel.Name = "filtro_hotel";
            this.filtro_hotel.Size = new System.Drawing.Size(202, 24);
            this.filtro_hotel.TabIndex = 42;
            // 
            // filtro_nacimiento
            // 
            this.filtro_nacimiento.Location = new System.Drawing.Point(651, 152);
            this.filtro_nacimiento.Name = "filtro_nacimiento";
            this.filtro_nacimiento.Size = new System.Drawing.Size(245, 22);
            this.filtro_nacimiento.TabIndex = 41;
            // 
            // filtro_direccion
            // 
            this.filtro_direccion.Location = new System.Drawing.Point(94, 149);
            this.filtro_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_direccion.Name = "filtro_direccion";
            this.filtro_direccion.Size = new System.Drawing.Size(160, 22);
            this.filtro_direccion.TabIndex = 37;
            // 
            // filtro_mail
            // 
            this.filtro_mail.Location = new System.Drawing.Point(360, 103);
            this.filtro_mail.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_mail.Name = "filtro_mail";
            this.filtro_mail.Size = new System.Drawing.Size(201, 22);
            this.filtro_mail.TabIndex = 38;
            // 
            // filtro_telefono
            // 
            this.filtro_telefono.Location = new System.Drawing.Point(651, 103);
            this.filtro_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_telefono.Name = "filtro_telefono";
            this.filtro_telefono.Size = new System.Drawing.Size(245, 22);
            this.filtro_telefono.TabIndex = 39;
            // 
            // filtro_nombre
            // 
            this.filtro_nombre.Location = new System.Drawing.Point(96, 100);
            this.filtro_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.filtro_nombre.Name = "filtro_nombre";
            this.filtro_nombre.Size = new System.Drawing.Size(159, 22);
            this.filtro_nombre.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label6.Location = new System.Drawing.Point(309, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hotel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label8.Location = new System.Drawing.Point(21, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label9.Location = new System.Drawing.Point(317, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(569, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Nombre";
            // 
            // tabla_usuario
            // 
            this.tabla_usuario.HeaderText = "Usuario";
            this.tabla_usuario.Name = "tabla_usuario";
            // 
            // tabla_roles
            // 
            this.tabla_roles.HeaderText = "Roles";
            this.tabla_roles.Name = "tabla_roles";
            this.tabla_roles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_roles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabla_nombre
            // 
            this.tabla_nombre.HeaderText = "Nombre";
            this.tabla_nombre.Name = "tabla_nombre";
            // 
            // tabla_documento
            // 
            this.tabla_documento.HeaderText = "Documento";
            this.tabla_documento.Name = "tabla_documento";
            // 
            // tabla_tipo
            // 
            this.tabla_tipo.HeaderText = "Tipo";
            this.tabla_tipo.Name = "tabla_tipo";
            // 
            // tabla_mail
            // 
            this.tabla_mail.HeaderText = "Mail";
            this.tabla_mail.Name = "tabla_mail";
            // 
            // tabla_telefono
            // 
            this.tabla_telefono.HeaderText = "Telefono";
            this.tabla_telefono.Name = "tabla_telefono";
            // 
            // tabla_direccion
            // 
            this.tabla_direccion.HeaderText = "Direccion";
            this.tabla_direccion.Name = "tabla_direccion";
            // 
            // talba_nacimiento
            // 
            this.talba_nacimiento.HeaderText = "Nacimiento";
            this.talba_nacimiento.Name = "talba_nacimiento";
            // 
            // tabla_hotel
            // 
            this.tabla_hotel.HeaderText = "Hotel";
            this.tabla_hotel.Name = "tabla_hotel";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label2.Location = new System.Drawing.Point(440, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Documento";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label14.Location = new System.Drawing.Point(496, 116);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tipo";
            // 
            // alta_documento
            // 
            this.alta_documento.Location = new System.Drawing.Point(111, 111);
            this.alta_documento.Margin = new System.Windows.Forms.Padding(4);
            this.alta_documento.Name = "alta_documento";
            this.alta_documento.Size = new System.Drawing.Size(299, 22);
            this.alta_documento.TabIndex = 11;
            // 
            // alta_tipo
            // 
            this.alta_tipo.FormattingEnabled = true;
            this.alta_tipo.Location = new System.Drawing.Point(570, 111);
            this.alta_tipo.Name = "alta_tipo";
            this.alta_tipo.Size = new System.Drawing.Size(252, 24);
            this.alta_tipo.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(483, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 24);
            this.comboBox2.TabIndex = 43;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1101, 697);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABM";
            this.Text = "ABM USUARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alta_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alta_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox alta_roles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox alta_mail;
        private System.Windows.Forms.TextBox alta_nombre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox alta_hotel;
        private System.Windows.Forms.DateTimePicker alta_nacimiento;
        private System.Windows.Forms.TextBox alta_direccion;
        private System.Windows.Forms.TextBox alta_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_usuario;
        private System.Windows.Forms.DataGridViewButtonColumn tabla_roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn talba_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_hotel;
        private System.Windows.Forms.DataGridViewButtonColumn modificar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.ComboBox filtro_hotel;
        private System.Windows.Forms.DateTimePicker filtro_nacimiento;
        private System.Windows.Forms.TextBox filtro_direccion;
        private System.Windows.Forms.TextBox filtro_mail;
        private System.Windows.Forms.TextBox filtro_telefono;
        private System.Windows.Forms.TextBox filtro_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox filtro_roles;
        private System.Windows.Forms.TextBox filtro_documento;
        private System.Windows.Forms.TextBox filtro_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox alta_tipo;
        private System.Windows.Forms.TextBox alta_documento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}