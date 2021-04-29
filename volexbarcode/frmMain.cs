using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dâyChuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLine addLine = new AddLine();
            //addLine.MdiParent = this;
            addLine.Show();

        }

        private void sảnPhẩmCanonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCanonPart frm = new frmCanonPart();
            frm.Show();
        }

        private void sảnPhẩmFujiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFuji frm = new frmAddFuji();
            frm.Show();
        }

        private void canonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScanCanon frm = new frmScanCanon();
            frm.Show();
        }

        private void fujiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScanFuji frm = new frmScanFuji();
            frm.Show();
        }

        private void báoCáoTheoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformation frm = new frmInformation();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!CheckConnection())
            {
                MessageBox.Show("Lỗi kết nối mạng!");
            }
        }
        public static bool CheckConnection()
        {
            try
            {
                using(ModelContext db = new ModelContext())
                {
                    db.Database.Connection.Open();
                    db.Database.Connection.Close();
                }

            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

    }
}
