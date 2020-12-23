using HopitalApp.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool AbrirFormulario(string name)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == name)
                {
                    for (int j = 0; j < TabForms.TabCount; j++)
                    {
                        string tabname = TabForms.TabPages[j].Text;
                        if (tabname == name)
                        {
                            TabForms.SelectedTab = TabForms.TabPages[j];
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Pass += new FrmLogin.PassData(Login);
            frmLogin.ShowDialog();
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                TabForms.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                this.ActiveMdiChild.Focus();
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = TabForms;
                    TabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!TabForms.Visible) TabForms.Visible = true;
                this.ActiveMdiChild.Focus();
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void TabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TabForms.SelectedTab != null) && (TabForms.SelectedTab.Tag != null))
            {
                (TabForms.SelectedTab.Tag as Form).Select();
                (TabForms.SelectedTab.Tag as Form).Activate();
                this.ActiveMdiChild.Activate();
            }
        }

        private void Login(bool exito)
        {
            MenuStrip.Enabled = exito;
        }

        private void formularioClinicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = AbrirFormulario("Formulario");
            if (open)
            {
                FrmFormularioClinico frmM = new FrmFormularioClinico();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = AbrirFormulario("Citas");
            if (open)
            {
                FrmListaCitas frmM = new FrmListaCitas();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = AbrirFormulario("Listar Facturas");
            if (open)
            {
                FormListarFacturas frmM = new FormListarFacturas();
                frmM.MdiParent = this;
                frmM.Show();
                frmM.WindowState = FormWindowState.Maximized;
            }

        }
    }
}
