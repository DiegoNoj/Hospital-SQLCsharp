namespace HopitalApp.Vistas
{
    partial class FrmListaCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnIDCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDgvDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDCita,
            this.ColumnDgvPaciente,
            this.ColumnDgvDocumento,
            this.ColumnFecha,
            this.ColumnCancelar});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(800, 450);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ColumnIDCita
            // 
            this.ColumnIDCita.HeaderText = "Id";
            this.ColumnIDCita.Name = "ColumnIDCita";
            this.ColumnIDCita.ReadOnly = true;
            this.ColumnIDCita.Visible = false;
            // 
            // ColumnDgvPaciente
            // 
            this.ColumnDgvPaciente.HeaderText = "Paciente";
            this.ColumnDgvPaciente.Name = "ColumnDgvPaciente";
            this.ColumnDgvPaciente.ReadOnly = true;
            // 
            // ColumnDgvDocumento
            // 
            this.ColumnDgvDocumento.HeaderText = "Documento";
            this.ColumnDgvDocumento.Name = "ColumnDgvDocumento";
            this.ColumnDgvDocumento.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnCancelar
            // 
            this.ColumnCancelar.HeaderText = "Cerrar";
            this.ColumnCancelar.Name = "ColumnCancelar";
            this.ColumnCancelar.ReadOnly = true;
            this.ColumnCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCancelar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmListaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView);
            this.Name = "FrmListaCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.FrmListaCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDgvDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCancelar;
    }
}