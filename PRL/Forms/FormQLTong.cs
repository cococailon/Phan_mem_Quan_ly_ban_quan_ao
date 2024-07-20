using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class FormQLTong : Form
    {
        public FormQLTong()
        {
            InitializeComponent();
        }


        private void chiTiếtSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CTSP ctsp = new CTSP();
            ctsp.TopLevel = false;
            ctsp.FormBorderStyle = FormBorderStyle.None;
            ctsp.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctsp);
            ctsp.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            QLSP sp = new QLSP();
            sp.TopLevel = false;
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
            panel1.Controls.Add(sp);
            sp.Show();
        }
    }
}
