using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            DateTime reportDate = dtp_report.Value.Date;
            DateTime start_shift = DateTime.Now;
            DateTime end_shift = DateTime.Now;
            switch (cmb_shift.Text)
            {
                case "Ca 1":
                    start_shift = reportDate.AddHours(6);
                    end_shift = start_shift.AddHours(8);
                    break;
                case "Ca 2":
                    start_shift = reportDate.AddHours(14);
                    end_shift = start_shift.AddHours(8);
                    break;
                case "Ca 3":
                    start_shift = reportDate.AddHours(22);
                    end_shift = start_shift.AddHours(8);
                    break;
            }
            using (ModelContext db = new ModelContext())
            {
                dgv_report.DataSource = db.Transactions.Where(z=> z.stampDate >= start_shift && z.stampDate <end_shift).GroupBy(x => new { x.line, x.partName, x.status }).Select(y => new { line = y.Key.line, part = y.Key.partName, status = y.Key.status, count = y.Count() }).ToList();
            }
            MessageBox.Show("Done!");
        }

    }
}
