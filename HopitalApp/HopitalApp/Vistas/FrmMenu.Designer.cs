namespace HopitalApp
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.formularioClinicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabForms = new System.Windows.Forms.TabControl();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Enabled = false;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioClinicoToolStripMenuItem,
            this.citaToolStripMenuItem,
            this.facturarToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(959, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.TabStop = true;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // formularioClinicoToolStripMenuItem
            // 
            this.formularioClinicoToolStripMenuItem.Name = "formularioClinicoToolStripMenuItem";
            this.formularioClinicoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.formularioClinicoToolStripMenuItem.Text = "Formulario clínico";
            this.formularioClinicoToolStripMenuItem.Click += new System.EventHandler(this.formularioClinicoToolStripMenuItem_Click);
            // 
            // TabForms
            // 
            this.TabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabForms.Location = new System.Drawing.Point(0, 24);
            this.TabForms.Name = "TabForms";
            this.TabForms.SelectedIndex = 0;
            this.TabForms.Size = new System.Drawing.Size(959, 24);
            this.TabForms.TabIndex = 4;
            this.TabForms.Visible = false;
            this.TabForms.SelectedIndexChanged += new System.EventHandler(this.TabForms_SelectedIndexChanged);
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.citaToolStripMenuItem.Text = "Citas Clinicas";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.facturarToolStripMenuItem.Text = "Facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.TabForms);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem formularioClinicoToolStripMenuItem;
        private System.Windows.Forms.TabControl TabForms;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
    }
}

