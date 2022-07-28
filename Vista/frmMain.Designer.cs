namespace CRM.Vista
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSalir = new System.Windows.Forms.Button();
            this.ctrlMenu1 = new CRM.Vista.ctrlMenu();
            this.ctrlMenuHome1 = new CRM.Vista.ctrlMenuHome();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(962, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ctrlMenu1
            // 
            this.ctrlMenu1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMenu1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlMenu1.Location = new System.Drawing.Point(815, 0);
            this.ctrlMenu1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlMenu1.Name = "ctrlMenu1";
            this.ctrlMenu1.Size = new System.Drawing.Size(180, 554);
            this.ctrlMenu1.TabIndex = 1;
            this.ctrlMenu1.Visible = false;
            // 
            // ctrlMenuHome1
            // 
            this.ctrlMenuHome1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrlMenuHome1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMenuHome1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlMenuHome1.Location = new System.Drawing.Point(0, 0);
            this.ctrlMenuHome1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlMenuHome1.Name = "ctrlMenuHome1";
            this.ctrlMenuHome1.Size = new System.Drawing.Size(180, 554);
            this.ctrlMenuHome1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(995, 554);
            this.Controls.Add(this.ctrlMenuHome1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ctrlMenu1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlMenu ctrlMenu1;
        private System.Windows.Forms.Button btnSalir;
        private ctrlMenuHome ctrlMenuHome1;
    }
}