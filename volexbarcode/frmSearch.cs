using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                cmb_line.DataSource = db.Lines.ToList();
                cmb_line.DisplayMember = "name";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (cmb_result.Text)
            {
                case "Tất cả":
                    result = "";
                    break;
                case "OK":
                    result = "OK";
                    break;
                case "NG":
                    result = "NG";
                    break;
            }
            DateTime from = dtp_from.Value;
            DateTime to = dtp_to.Value;
            using (ModelContext db = new ModelContext())
            {
                dgv_report.DataSource = db.Transactions.Where(x => x.stampDate >= from && x.stampDate <= to && x.line.Equals(cmb_line.Text) && x.status.Contains(result)).ToList();
            }
        }
    }
}
