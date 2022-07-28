namespace CRM.Vista
{
    partial class frmBClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtGrid1 = new System.Windows.Forms.DataGridView();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.rbLlamarDespues = new System.Windows.Forms.RadioButton();
            this.rbEnGestion = new System.Windows.Forms.RadioButton();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.rbStandBy = new System.Windows.Forms.RadioButton();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.rbSinContacto = new System.Windows.Forms.RadioButton();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ctrlMenuHome = new CRM.Vista.ctrlMenuHome();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.gbEstados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.dtGrid1);
            this.panel1.Controls.Add(this.gbBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(184, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 554);
            this.panel1.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(773, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtGrid1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid1.Location = new System.Drawing.Point(14, 169);
            this.dtGrid1.Name = "dtGrid1";
            this.dtGrid1.ReadOnly = true;
            this.dtGrid1.Size = new System.Drawing.Size(783, 372);
            this.dtGrid1.TabIndex = 1;
            this.dtGrid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid1_CellContentDoubleClick);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.gbEstados);
            this.gbBuscar.Controls.Add(this.txtCelular);
            this.gbBuscar.Controls.Add(this.txtNombre);
            this.gbBuscar.Controls.Add(this.lblCelular);
            this.gbBuscar.Controls.Add(this.lblNombre);
            this.gbBuscar.Controls.Add(this.lblBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(14, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(783, 154);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.btnBuscar);
            this.gbEstados.Controls.Add(this.lblEstados);
            this.gbEstados.Controls.Add(this.rbLlamarDespues);
            this.gbEstados.Controls.Add(this.rbEnGestion);
            this.gbEstados.Controls.Add(this.rbVendido);
            this.gbEstados.Controls.Add(this.rbStandBy);
            this.gbEstados.Controls.Add(this.rbEliminado);
            this.gbEstados.Controls.Add(this.rbSinContacto);
            this.gbEstados.Location = new System.Drawing.Point(7, 56);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(769, 92);
            this.gbEstados.TabIndex = 28;
            this.gbEstados.TabStop = false;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.lblEstados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEstados.Location = new System.Drawing.Point(9, -4);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(57, 17);
            this.lblEstados.TabIndex = 0;
            this.lblEstados.Text = "Estados";
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
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Location = new System.Drawing.Point(571, 26);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(183, 14);
            this.txtCelular.TabIndex = 1;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(184, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 14);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCelular.Location = new System.Drawing.Point(437, 26);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(128, 17);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombre.Location = new System.Drawing.Point(23, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBuscar.Location = new System.Drawing.Point(23, -4);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Image = global::CRM.Properties.Resources.BuscarCliente_16;
            this.btnBuscar.Location = new System.Drawing.Point(655, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 30);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.ctrlMenuHome.TabIndex = 9;
            // 
            // frmBClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(995, 554);
            this.Controls.Add(this.ctrlMenuHome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBClientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlMenuHome ctrlMenuHome1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.RadioButton rbLlamarDespues;
        private System.Windows.Forms.RadioButton rbEnGestion;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.RadioButton rbStandBy;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.RadioButton rbSinContacto;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.DataGridView dtGrid1;
        private ctrlMenuHome ctrlMenuHome;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
    }
}