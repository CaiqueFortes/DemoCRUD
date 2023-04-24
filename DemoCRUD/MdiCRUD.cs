using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCRUD
{
    public partial class MdiCRUD : Form
    {
        frmAgenda? AgendaForm;
        frmCEP? CEPForm;

        public MdiCRUD()
        {
            InitializeComponent();
        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (AgendaForm == null)
            {
                AgendaForm = new frmAgenda();
                AgendaForm.MdiParent = this;
                AgendaForm.WindowState = FormWindowState.Maximized;
                AgendaForm.Show();
            }
            else
            {
                AgendaForm.Activate();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CEPForm == null)
            {
                CEPForm = new frmCEP();
                CEPForm.MdiParent = this;
                CEPForm.WindowState = FormWindowState.Maximized;
                CEPForm.Show();
            }
            else
            {
                CEPForm.Activate();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre SobreForm = new frmSobre();
            SobreForm.ShowDialog();
        }
    }
}
