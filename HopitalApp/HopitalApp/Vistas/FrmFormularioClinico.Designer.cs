namespace HopitalApp.Vistas
{
    partial class FrmFormularioClinico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LbCosto = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CboDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDdvIdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtPaciente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 102);
            this.panel1.TabIndex = 0;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(113, 62);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(378, 26);
            this.TxtCliente.TabIndex = 5;
            this.TxtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encargado:";
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaciente.Location = new System.Drawing.Point(95, 34);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(396, 26);
            this.TxtPaciente.TabIndex = 3;
            this.TxtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente:";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(79, 6);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(143, 26);
            this.TxtId.TabIndex = 1;
            this.TxtId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.LbCosto);
            this.panel2.Controls.Add(this.DateTimePicker);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CboDoctor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CboServicio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 83);
            this.panel2.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(390, 49);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(101, 29);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LbCosto
            // 
            this.LbCosto.AutoSize = true;
            this.LbCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCosto.Location = new System.Drawing.Point(707, 51);
            this.LbCosto.Name = "LbCosto";
            this.LbCosto.Size = new System.Drawing.Size(44, 20);
            this.LbCosto.TabIndex = 7;
            this.LbCosto.Text = "0.00";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(79, 48);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(180, 26);
            this.DateTimePicker.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha:";
            // 
            // CboDoctor
            // 
            this.CboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDoctor.FormattingEnabled = true;
            this.CboDoctor.Location = new System.Drawing.Point(478, 14);
            this.CboDoctor.Name = "CboDoctor";
            this.CboDoctor.Size = new System.Drawing.Size(221, 28);
            this.CboDoctor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doctor:";
            // 
            // CboServicio
            // 
            this.CboServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboServicio.FormattingEnabled = true;
            this.CboServicio.Location = new System.Drawing.Point(85, 14);
            this.CboServicio.Name = "CboServicio";
            this.CboServicio.Size = new System.Drawing.Size(288, 28);
            this.CboServicio.TabIndex = 1;
            this.CboServicio.SelectedIndexChanged += new System.EventHandler(this.CboServicio_SelectedIndexChanged);
            this.CboServicio.SelectedValueChanged += new System.EventHandler(this.CboServicio_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Servicio:";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDdvIdDetalle,
            this.ColumnDgvServicio,
            this.ColumnDgvDoctor,
            this.ColumnDgvFecha,
            this.ColumnDgvCosto});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 185);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(800, 265);
            this.DataGridView.TabIndex = 2;
            // 
            // ColumnDdvIdDetalle
            // 
            this.ColumnDdvIdDetalle.HeaderText = "IdDetalle";
            this.ColumnDdvIdDetalle.Name = "ColumnDdvIdDetalle";
            this.ColumnDdvIdDetalle.ReadOnly = true;
            // 
            // ColumnDgvServicio
            // 
            this.ColumnDgvServicio.HeaderText = "Servicio";
            this.ColumnDgvServicio.Name = "ColumnDgvServicio";
            this.ColumnDgvServicio.ReadOnly = true;
            // 
            // ColumnDgvDoctor
            // 
            this.ColumnDgvDoctor.HeaderText = "Doctor";
            this.ColumnDgvDoctor.Name = "ColumnDgvDoctor";
            this.ColumnDgvDoctor.ReadOnly = true;
            // 
            // ColumnDgvFecha
            // 
            this.ColumnDgvFecha.HeaderText = "Fecha";
            this.ColumnDgvFecha.Name = "ColumnDgvFecha";
            this.ColumnDgvFecha.ReadOnly = true;
            // 
            // ColumnDgvCosto
            // 
            this.ColumnDgvCosto.HeaderText = "Costo";
            this.ColumnDgvCosto.Name = "ColumnDgvCosto";
            this.ColumnDgvCosto.ReadOnly = true;
            // 
            // FrmFormularioClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFormularioClinico";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FrmFormularioClinico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbCosto;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDdvIdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvCosto;
        private System.Windows.Forms.Button BtnAgregar;
    }
}