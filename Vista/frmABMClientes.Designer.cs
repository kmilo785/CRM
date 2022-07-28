namespace CRM.Vista
{
    partial class frmABMClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.rbLlamarDespues = new System.Windows.Forms.RadioButton();
            this.rbEnGestion = new System.Windows.Forms.RadioButton();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.rbStandBy = new System.Windows.Forms.RadioButton();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.rbSinContacto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbComentarios = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTipoPlan = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ctrlMenuHome = new CRM.Vista.ctrlMenuHome();
            this.panel1.SuspendLayout();
            this.gbEstados.SuspendLayout();
            this.gbComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.gbEstados);
            this.panel1.Controls.Add(this.gbComentarios);
            this.panel1.Controls.Add(this.dtFechaNacimiento);
            this.panel1.Controls.Add(this.cbEstados);
            this.panel1.Controls.Add(this.cbOrigen);
            this.panel1.Controls.Add(this.txtFechaIngreso);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtTipoPlan);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblIngreso);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblNacimiento);
            this.panel1.Controls.Add(this.lblTipoPlan);
            this.panel1.Controls.Add(this.lblCiudad);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblOrigen);
            this.panel1.Controls.Add(this.lblCelular);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 554);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CRM.Properties.Resources.Trash_16;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(678, 494);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 30);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLimpiar.Image = global::CRM.Properties.Resources.Limpiar_16;
            this.btnLimpiar.Location = new System.Drawing.Point(338, 494);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEditar.Image = global::CRM.Properties.Resources.Edit_16;
            this.btnEditar.Location = new System.Drawing.Point(186, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 30);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGuardar.Image = global::CRM.Properties.Resources.Save_16;
            this.btnGuardar.Location = new System.Drawing.Point(34, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 30);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnNuevo.Image = global::CRM.Properties.Resources.Cliente_16;
            this.btnNuevo.Location = new System.Drawing.Point(34, 494);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 30);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.rbLlamarDespues);
            this.gbEstados.Controls.Add(this.rbEnGestion);
            this.gbEstados.Controls.Add(this.rbVendido);
            this.gbEstados.Controls.Add(this.rbStandBy);
            this.gbEstados.Controls.Add(this.rbEliminado);
            this.gbEstados.Controls.Add(this.rbSinContacto);
            this.gbEstados.Controls.Add(this.label2);
            this.gbEstados.Location = new System.Drawing.Point(34, 416);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(769, 57);
            this.gbEstados.TabIndex = 27;
            this.gbEstados.TabStop = false;
            // 
            // rbLlamarDespues
            // 
            this.rbLlamarDespues.AutoSize = true;
            this.rbLlamarDespues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbLlamarDespues.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbLlamarDespues.ForeColor = System.Drawing.Color.Black;
            this.rbLlamarDespues.Location = new System.Drawing.Point(619, 20);
            this.rbLlamarDespues.Name = "rbLlamarDespues";
            this.rbLlamarDespues.Size = new System.Drawing.Size(127, 21);
            this.rbLlamarDespues.TabIndex = 1;
            this.rbLlamarDespues.TabStop = true;
            this.rbLlamarDespues.Text = "Llamar Despues";
            this.rbLlamarDespues.UseVisualStyleBackColor = false;
            // 
            // rbEnGestion
            // 
            this.rbEnGestion.AutoSize = true;
            this.rbEnGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbEnGestion.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbEnGestion.ForeColor = System.Drawing.Color.Black;
            this.rbEnGestion.Location = new System.Drawing.Point(498, 20);
            this.rbEnGestion.Name = "rbEnGestion";
            this.rbEnGestion.Size = new System.Drawing.Size(94, 21);
            this.rbEnGestion.TabIndex = 1;
            this.rbEnGestion.TabStop = true;
            this.rbEnGestion.Text = "En Gestión";
            this.rbEnGestion.UseVisualStyleBackColor = false;
            // 
            // rbVendido
            // 
            this.rbVendido.AutoSize = true;
            this.rbVendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbVendido.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbVendido.ForeColor = System.Drawing.Color.Black;
            this.rbVendido.Location = new System.Drawing.Point(390, 20);
            this.rbVendido.Name = "rbVendido";
            this.rbVendido.Size = new System.Drawing.Size(81, 21);
            this.rbVendido.TabIndex = 1;
            this.rbVendido.TabStop = true;
            this.rbVendido.Text = "Vendido";
            this.rbVendido.UseVisualStyleBackColor = false;
            // 
            // rbStandBy
            // 
            this.rbStandBy.AutoSize = true;
            this.rbStandBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbStandBy.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbStandBy.ForeColor = System.Drawing.Color.Black;
            this.rbStandBy.Location = new System.Drawing.Point(283, 20);
            this.rbStandBy.Name = "rbStandBy";
            this.rbStandBy.Size = new System.Drawing.Size(80, 21);
            this.rbStandBy.TabIndex = 1;
            this.rbStandBy.TabStop = true;
            this.rbStandBy.Text = "Stand By";
            this.rbStandBy.UseVisualStyleBackColor = false;
            // 
            // rbEliminado
            // 
            this.rbEliminado.AutoSize = true;
            this.rbEliminado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbEliminado.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbEliminado.ForeColor = System.Drawing.Color.Black;
            this.rbEliminado.Location = new System.Drawing.Point(166, 20);
            this.rbEliminado.Name = "rbEliminado";
            this.rbEliminado.Size = new System.Drawing.Size(90, 21);
            this.rbEliminado.TabIndex = 1;
            this.rbEliminado.TabStop = true;
            this.rbEliminado.Text = "Eliminado";
            this.rbEliminado.UseVisualStyleBackColor = false;
            // 
            // rbSinContacto
            // 
            this.rbSinContacto.AutoSize = true;
            this.rbSinContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbSinContacto.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.rbSinContacto.ForeColor = System.Drawing.Color.Black;
            this.rbSinContacto.Location = new System.Drawing.Point(28, 20);
            this.rbSinContacto.Name = "rbSinContacto";
            this.rbSinContacto.Size = new System.Drawing.Size(111, 21);
            this.rbSinContacto.TabIndex = 1;
            this.rbSinContacto.TabStop = true;
            this.rbSinContacto.Text = "Sin Contacto";
            this.rbSinContacto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estados";
            // 
            // gbComentarios
            // 
            this.gbComentarios.BackColor = System.Drawing.Color.Transparent;
            this.gbComentarios.Controls.Add(this.txtComentarios);
            this.gbComentarios.Controls.Add(this.label1);
            this.gbComentarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComentarios.Location = new System.Drawing.Point(389, 68);
            this.gbComentarios.Name = "gbComentarios";
            this.gbComentarios.Size = new System.Drawing.Size(414, 332);
            this.gbComentarios.TabIndex = 12;
            this.gbComentarios.TabStop = false;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(21, 30);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(375, 284);
            this.txtComentarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comentarios";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(196, 341);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(180, 22);
            this.dtFechaNacimiento.TabIndex = 9;
            // 
            // cbEstados
            // 
            this.cbEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(168, 375);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(208, 25);
            this.cbEstados.TabIndex = 11;
            this.cbEstados.Visible = false;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrigen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(168, 144);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(208, 25);
            this.cbOrigen.TabIndex = 2;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.Location = new System.Drawing.Point(168, 378);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(208, 15);
            this.txtFechaIngreso.TabIndex = 10;
            this.txtFechaIngreso.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 26;
            this.txtID.TabStop = false;
            this.txtID.Visible = false;
            // 
            // txtTipoPlan
            // 
            this.txtTipoPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoPlan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPlan.Location = new System.Drawing.Point(168, 310);
            this.txtTipoPlan.Name = "txtTipoPlan";
            this.txtTipoPlan.Size = new System.Drawing.Size(208, 15);
            this.txtTipoPlan.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(168, 279);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(208, 15);
            this.txtCiudad.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 15);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(168, 213);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(208, 15);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(168, 182);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(208, 15);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(168, 116);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(208, 15);
            this.txtCelular.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(168, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 15);
            this.txtNombre.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(385, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 19);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Detalles del Cliente";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(35, 378);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(110, 17);
            this.lblIngreso.TabIndex = 11;
            this.lblIngreso.Text = "Fecha de Ingreso";
            this.lblIngreso.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(35, 378);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(35, 345);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(137, 17);
            this.lblNacimiento.TabIndex = 9;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(35, 312);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(79, 17);
            this.lblTipoPlan.TabIndex = 8;
            this.lblTipoPlan.Text = "Tipo de Plan";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(35, 279);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 17);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(35, 246);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(35, 213);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 17);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(35, 180);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(35, 147);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(81, 17);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen Dato";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(35, 114);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 17);
            this.lblCelular.TabIndex = 1;
            this.lblCelular.Text = "Celular";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(35, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(776, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ctrlMenuHome
            // 
            this.ctrlMenuHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrlMenuHome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlMenuHome.Location = new System.Drawing.Point(0, 0);
            this.ctrlMenuHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlMenuHome.Name = "ctrlMenuHome";
            this.ctrlMenuHome.Size = new System.Drawing.Size(180, 554);
            this.ctrlMenuHome.TabIndex = 0;
            // 
            // frmABMClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(995, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlMenuHome);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmABMClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMClientes";
            this.Load += new System.EventHandler(this.frmABMClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.gbComentarios.ResumeLayout(false);
            this.gbComentarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMenuHome ctrlMenuHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipoPlan;
        private System.Windows.Forms.GroupBox gbComentarios;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLlamarDespues;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.RadioButton rbStandBy;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.RadioButton rbSinContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RadioButton rbEnGestion;
    }
}