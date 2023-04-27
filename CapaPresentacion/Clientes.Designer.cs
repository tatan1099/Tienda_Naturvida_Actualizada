namespace CapaPresentacion
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgCopnsultar = new System.Windows.Forms.TabPage();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.cmbCC = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnConsultartodo = new System.Windows.Forms.Button();
            this.DgvCClientes = new System.Windows.Forms.DataGridView();
            this.TpgInsertar = new System.Windows.Forms.TabPage();
            this.LblVerificarNombre = new System.Windows.Forms.Label();
            this.LblVerificvarDocumento = new System.Windows.Forms.Label();
            this.LblValidarCorreo = new System.Windows.Forms.Label();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCorreoInsertar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.TxtTelefonoInsertar = new System.Windows.Forms.TextBox();
            this.TxtDireccionInsertar = new System.Windows.Forms.TextBox();
            this.TxtNombreInsertar = new System.Windows.Forms.TextBox();
            this.TxtDocumentoInsertar = new System.Windows.Forms.TextBox();
            this.TpgModificar = new System.Windows.Forms.TabPage();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.DgvEditarClientes = new System.Windows.Forms.DataGridView();
            this.BtnConsultarEditarCliente = new System.Windows.Forms.Button();
            this.CmbModificarClientes = new System.Windows.Forms.ComboBox();
            this.TxtCorreoEditar = new System.Windows.Forms.TextBox();
            this.TxtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.TxtDireccionEditar = new System.Windows.Forms.TextBox();
            this.TxtNombreEditar = new System.Windows.Forms.TextBox();
            this.TxtDocumentoEditar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TpgEliminar = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.cmbEliminarClientes = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TpgCopnsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCClientes)).BeginInit();
            this.TpgInsertar.SuspendLayout();
            this.TpgModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditarClientes)).BeginInit();
            this.TpgEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpgCopnsultar);
            this.tabControl1.Controls.Add(this.TpgInsertar);
            this.tabControl1.Controls.Add(this.TpgModificar);
            this.tabControl1.Controls.Add(this.TpgEliminar);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // TpgCopnsultar
            // 
            this.TpgCopnsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.TpgCopnsultar.Controls.Add(this.BtnVolver);
            this.TpgCopnsultar.Controls.Add(this.cmbCC);
            this.TpgCopnsultar.Controls.Add(this.BtnConsultar);
            this.TpgCopnsultar.Controls.Add(this.BtnConsultartodo);
            this.TpgCopnsultar.Controls.Add(this.DgvCClientes);
            this.TpgCopnsultar.Location = new System.Drawing.Point(4, 22);
            this.TpgCopnsultar.Name = "TpgCopnsultar";
            this.TpgCopnsultar.Padding = new System.Windows.Forms.Padding(3);
            this.TpgCopnsultar.Size = new System.Drawing.Size(889, 419);
            this.TpgCopnsultar.TabIndex = 0;
            this.TpgCopnsultar.Text = "Consultar";
            this.TpgCopnsultar.Click += new System.EventHandler(this.TpgCopnsultar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnVolver.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnVolver.Location = new System.Drawing.Point(681, 3);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(202, 46);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // cmbCC
            // 
            this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCC.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCC.FormattingEnabled = true;
            this.cmbCC.Location = new System.Drawing.Point(308, 29);
            this.cmbCC.Name = "cmbCC";
            this.cmbCC.Size = new System.Drawing.Size(248, 33);
            this.cmbCC.TabIndex = 3;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnConsultar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnConsultar.Location = new System.Drawing.Point(183, 87);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(202, 46);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnConsultartodo
            // 
            this.BtnConsultartodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnConsultartodo.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultartodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnConsultartodo.Location = new System.Drawing.Point(455, 87);
            this.BtnConsultartodo.Name = "BtnConsultartodo";
            this.BtnConsultartodo.Size = new System.Drawing.Size(202, 46);
            this.BtnConsultartodo.TabIndex = 1;
            this.BtnConsultartodo.Text = "Consultar Todo";
            this.BtnConsultartodo.UseVisualStyleBackColor = false;
            this.BtnConsultartodo.Click += new System.EventHandler(this.BtnConsultartodo_Click);
            // 
            // DgvCClientes
            // 
            this.DgvCClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.DgvCClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.DgvCClientes.Location = new System.Drawing.Point(74, 178);
            this.DgvCClientes.Name = "DgvCClientes";
            this.DgvCClientes.Size = new System.Drawing.Size(750, 212);
            this.DgvCClientes.TabIndex = 0;
            this.DgvCClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCClientes_CellContentClick);
            // 
            // TpgInsertar
            // 
            this.TpgInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.TpgInsertar.Controls.Add(this.LblVerificarNombre);
            this.TpgInsertar.Controls.Add(this.LblVerificvarDocumento);
            this.TpgInsertar.Controls.Add(this.LblValidarCorreo);
            this.TpgInsertar.Controls.Add(this.BtnInsertar);
            this.TpgInsertar.Controls.Add(this.label1);
            this.TpgInsertar.Controls.Add(this.TxtCorreoInsertar);
            this.TpgInsertar.Controls.Add(this.label4);
            this.TpgInsertar.Controls.Add(this.label3);
            this.TpgInsertar.Controls.Add(this.label2);
            this.TpgInsertar.Controls.Add(this.LblDocumento);
            this.TpgInsertar.Controls.Add(this.TxtTelefonoInsertar);
            this.TpgInsertar.Controls.Add(this.TxtDireccionInsertar);
            this.TpgInsertar.Controls.Add(this.TxtNombreInsertar);
            this.TpgInsertar.Controls.Add(this.TxtDocumentoInsertar);
            this.TpgInsertar.Location = new System.Drawing.Point(4, 22);
            this.TpgInsertar.Name = "TpgInsertar";
            this.TpgInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.TpgInsertar.Size = new System.Drawing.Size(889, 419);
            this.TpgInsertar.TabIndex = 1;
            this.TpgInsertar.Text = "Insertar";
            this.TpgInsertar.Click += new System.EventHandler(this.TpgInsertar_Click);
            // 
            // LblVerificarNombre
            // 
            this.LblVerificarNombre.AutoSize = true;
            this.LblVerificarNombre.Location = new System.Drawing.Point(562, 82);
            this.LblVerificarNombre.Name = "LblVerificarNombre";
            this.LblVerificarNombre.Size = new System.Drawing.Size(0, 13);
            this.LblVerificarNombre.TabIndex = 13;
            // 
            // LblVerificvarDocumento
            // 
            this.LblVerificvarDocumento.AutoSize = true;
            this.LblVerificvarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerificvarDocumento.Location = new System.Drawing.Point(208, 80);
            this.LblVerificvarDocumento.Name = "LblVerificvarDocumento";
            this.LblVerificvarDocumento.Size = new System.Drawing.Size(0, 15);
            this.LblVerificvarDocumento.TabIndex = 12;
            // 
            // LblValidarCorreo
            // 
            this.LblValidarCorreo.AutoSize = true;
            this.LblValidarCorreo.Location = new System.Drawing.Point(562, 248);
            this.LblValidarCorreo.Name = "LblValidarCorreo";
            this.LblValidarCorreo.Size = new System.Drawing.Size(0, 13);
            this.LblValidarCorreo.TabIndex = 11;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnInsertar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnInsertar.Location = new System.Drawing.Point(362, 326);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(110, 38);
            this.BtnInsertar.TabIndex = 10;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(268, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correo";
            // 
            // TxtCorreoInsertar
            // 
            this.TxtCorreoInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtCorreoInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoInsertar.Location = new System.Drawing.Point(362, 244);
            this.TxtCorreoInsertar.Name = "TxtCorreoInsertar";
            this.TxtCorreoInsertar.Size = new System.Drawing.Size(172, 26);
            this.TxtCorreoInsertar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(425, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(59, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(425, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.LblDocumento.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.LblDocumento.Location = new System.Drawing.Point(59, 47);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(119, 25);
            this.LblDocumento.TabIndex = 4;
            this.LblDocumento.Text = "Documento";
            // 
            // TxtTelefonoInsertar
            // 
            this.TxtTelefonoInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtTelefonoInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoInsertar.Location = new System.Drawing.Point(548, 157);
            this.TxtTelefonoInsertar.Name = "TxtTelefonoInsertar";
            this.TxtTelefonoInsertar.Size = new System.Drawing.Size(156, 26);
            this.TxtTelefonoInsertar.TabIndex = 3;
            this.TxtTelefonoInsertar.TextChanged += new System.EventHandler(this.TxtTelefonoInsertar_TextChanged);
            // 
            // TxtDireccionInsertar
            // 
            this.TxtDireccionInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtDireccionInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionInsertar.Location = new System.Drawing.Point(199, 157);
            this.TxtDireccionInsertar.Name = "TxtDireccionInsertar";
            this.TxtDireccionInsertar.Size = new System.Drawing.Size(143, 26);
            this.TxtDireccionInsertar.TabIndex = 2;
            // 
            // TxtNombreInsertar
            // 
            this.TxtNombreInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtNombreInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreInsertar.Location = new System.Drawing.Point(548, 51);
            this.TxtNombreInsertar.Name = "TxtNombreInsertar";
            this.TxtNombreInsertar.Size = new System.Drawing.Size(156, 26);
            this.TxtNombreInsertar.TabIndex = 1;
            this.TxtNombreInsertar.TextChanged += new System.EventHandler(this.TxtNombreInsertar_TextChanged);
            // 
            // TxtDocumentoInsertar
            // 
            this.TxtDocumentoInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtDocumentoInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumentoInsertar.Location = new System.Drawing.Point(199, 51);
            this.TxtDocumentoInsertar.Name = "TxtDocumentoInsertar";
            this.TxtDocumentoInsertar.Size = new System.Drawing.Size(143, 26);
            this.TxtDocumentoInsertar.TabIndex = 0;
            this.TxtDocumentoInsertar.TextChanged += new System.EventHandler(this.TxtDocumentoInsertar_TextChanged);
            // 
            // TpgModificar
            // 
            this.TpgModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.TpgModificar.Controls.Add(this.BtnEditar);
            this.TpgModificar.Controls.Add(this.DgvEditarClientes);
            this.TpgModificar.Controls.Add(this.BtnConsultarEditarCliente);
            this.TpgModificar.Controls.Add(this.CmbModificarClientes);
            this.TpgModificar.Controls.Add(this.TxtCorreoEditar);
            this.TpgModificar.Controls.Add(this.TxtTelefonoEditar);
            this.TpgModificar.Controls.Add(this.TxtDireccionEditar);
            this.TpgModificar.Controls.Add(this.TxtNombreEditar);
            this.TpgModificar.Controls.Add(this.TxtDocumentoEditar);
            this.TpgModificar.Controls.Add(this.label9);
            this.TpgModificar.Controls.Add(this.label8);
            this.TpgModificar.Controls.Add(this.label7);
            this.TpgModificar.Controls.Add(this.label6);
            this.TpgModificar.Controls.Add(this.label5);
            this.TpgModificar.Location = new System.Drawing.Point(4, 22);
            this.TpgModificar.Name = "TpgModificar";
            this.TpgModificar.Padding = new System.Windows.Forms.Padding(3);
            this.TpgModificar.Size = new System.Drawing.Size(889, 419);
            this.TpgModificar.TabIndex = 2;
            this.TpgModificar.Text = "Modificar";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnEditar.Location = new System.Drawing.Point(33, 315);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 44);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // DgvEditarClientes
            // 
            this.DgvEditarClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.DgvEditarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEditarClientes.Location = new System.Drawing.Point(171, 255);
            this.DgvEditarClientes.Name = "DgvEditarClientes";
            this.DgvEditarClientes.Size = new System.Drawing.Size(696, 164);
            this.DgvEditarClientes.TabIndex = 13;
            // 
            // BtnConsultarEditarCliente
            // 
            this.BtnConsultarEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnConsultarEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnConsultarEditarCliente.Location = new System.Drawing.Point(481, 35);
            this.BtnConsultarEditarCliente.Name = "BtnConsultarEditarCliente";
            this.BtnConsultarEditarCliente.Size = new System.Drawing.Size(123, 34);
            this.BtnConsultarEditarCliente.TabIndex = 12;
            this.BtnConsultarEditarCliente.Text = "Consultar";
            this.BtnConsultarEditarCliente.UseVisualStyleBackColor = false;
            this.BtnConsultarEditarCliente.Click += new System.EventHandler(this.BtnConsultarEditarCliente_Click);
            // 
            // CmbModificarClientes
            // 
            this.CmbModificarClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModificarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbModificarClientes.FormattingEnabled = true;
            this.CmbModificarClientes.Location = new System.Drawing.Point(246, 35);
            this.CmbModificarClientes.Name = "CmbModificarClientes";
            this.CmbModificarClientes.Size = new System.Drawing.Size(214, 32);
            this.CmbModificarClientes.TabIndex = 11;
            // 
            // TxtCorreoEditar
            // 
            this.TxtCorreoEditar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtCorreoEditar.Location = new System.Drawing.Point(731, 145);
            this.TxtCorreoEditar.Name = "TxtCorreoEditar";
            this.TxtCorreoEditar.Size = new System.Drawing.Size(136, 28);
            this.TxtCorreoEditar.TabIndex = 9;
            // 
            // TxtTelefonoEditar
            // 
            this.TxtTelefonoEditar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtTelefonoEditar.Location = new System.Drawing.Point(463, 191);
            this.TxtTelefonoEditar.Name = "TxtTelefonoEditar";
            this.TxtTelefonoEditar.Size = new System.Drawing.Size(123, 28);
            this.TxtTelefonoEditar.TabIndex = 8;
            this.TxtTelefonoEditar.TextChanged += new System.EventHandler(this.TxtTelefonoEditar_TextChanged);
            // 
            // TxtDireccionEditar
            // 
            this.TxtDireccionEditar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtDireccionEditar.Location = new System.Drawing.Point(180, 191);
            this.TxtDireccionEditar.Name = "TxtDireccionEditar";
            this.TxtDireccionEditar.Size = new System.Drawing.Size(137, 28);
            this.TxtDireccionEditar.TabIndex = 7;
            // 
            // TxtNombreEditar
            // 
            this.TxtNombreEditar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtNombreEditar.Location = new System.Drawing.Point(463, 108);
            this.TxtNombreEditar.Name = "TxtNombreEditar";
            this.TxtNombreEditar.Size = new System.Drawing.Size(123, 28);
            this.TxtNombreEditar.TabIndex = 6;
            // 
            // TxtDocumentoEditar
            // 
            this.TxtDocumentoEditar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumentoEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtDocumentoEditar.Location = new System.Drawing.Point(180, 105);
            this.TxtDocumentoEditar.Name = "TxtDocumentoEditar";
            this.TxtDocumentoEditar.ReadOnly = true;
            this.TxtDocumentoEditar.Size = new System.Drawing.Size(137, 28);
            this.TxtDocumentoEditar.TabIndex = 5;
            this.TxtDocumentoEditar.TextChanged += new System.EventHandler(this.TxtDocumentoEditar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(631, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label8.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(347, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(28, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dirrecion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(347, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(28, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Documento";
            // 
            // TpgEliminar
            // 
            this.TpgEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.TpgEliminar.Controls.Add(this.BtnEliminar);
            this.TpgEliminar.Controls.Add(this.cmbEliminarClientes);
            this.TpgEliminar.Location = new System.Drawing.Point(4, 22);
            this.TpgEliminar.Name = "TpgEliminar";
            this.TpgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.TpgEliminar.Size = new System.Drawing.Size(889, 419);
            this.TpgEliminar.TabIndex = 3;
            this.TpgEliminar.Text = "Eliminar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnEliminar.Location = new System.Drawing.Point(345, 178);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(136, 57);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // cmbEliminarClientes
            // 
            this.cmbEliminarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cmbEliminarClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEliminarClientes.FormattingEnabled = true;
            this.cmbEliminarClientes.Location = new System.Drawing.Point(294, 108);
            this.cmbEliminarClientes.Name = "cmbEliminarClientes";
            this.cmbEliminarClientes.Size = new System.Drawing.Size(244, 33);
            this.cmbEliminarClientes.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpgCopnsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCClientes)).EndInit();
            this.TpgInsertar.ResumeLayout(false);
            this.TpgInsertar.PerformLayout();
            this.TpgModificar.ResumeLayout(false);
            this.TpgModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEditarClientes)).EndInit();
            this.TpgEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgCopnsultar;
        private System.Windows.Forms.TabPage TpgInsertar;
        private System.Windows.Forms.TabPage TpgModificar;
        private System.Windows.Forms.TabPage TpgEliminar;
        private System.Windows.Forms.DataGridView DgvCClientes;
        private System.Windows.Forms.ComboBox cmbCC;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnConsultartodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.TextBox TxtTelefonoInsertar;
        private System.Windows.Forms.TextBox TxtDireccionInsertar;
        private System.Windows.Forms.TextBox TxtNombreInsertar;
        private System.Windows.Forms.TextBox TxtDocumentoInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCorreoInsertar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnConsultarEditarCliente;
        private System.Windows.Forms.ComboBox CmbModificarClientes;
        private System.Windows.Forms.TextBox TxtCorreoEditar;
        private System.Windows.Forms.TextBox TxtTelefonoEditar;
        private System.Windows.Forms.TextBox TxtDireccionEditar;
        private System.Windows.Forms.TextBox TxtNombreEditar;
        private System.Windows.Forms.TextBox TxtDocumentoEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvEditarClientes;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ComboBox cmbEliminarClientes;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LblValidarCorreo;
        private System.Windows.Forms.Label LblVerificvarDocumento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label LblVerificarNombre;
    }
}