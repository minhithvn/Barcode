using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class frmScanFuji : Form
    {
        int ok = 0;
        int ng = 0;
        string line = "";
        string part = "";
        string reg = "";
        public frmScanFuji()
        {
            InitializeComponent();
        }

        private void frmScanFuji_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                comb_line.DataSource = db.Lines.ToList();
                comb_line.DisplayMember = "name";
                comb_line.ValueMember = "name";

                comb_part.DataSource = db.FujiParts.ToList();
                comb_part.DisplayMember = "name";
                comb_part.ValueMember = "reg";

            }
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "volex")
            {
                lock_input(true);
                txt_password.Text = "";
                txt_barcode.Focus();
            }
        }
        void lock_input(bool flag)
        {
            txt_barcode.Enabled = comb_line.Enabled = comb_part.Enabled = btn_start.Enabled = dgv_NG.Enabled  = flag;
            txt_password.Enabled = btn_unlock.Enabled = lab_erorr.Visible = !flag;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"doorbell.wav");
            player.Play();
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                using(ModelContext db = new ModelContext())
                {
                    Transaction transaction = new Transaction();
                    transaction.line = line;
                    transaction.partName = part;
                    transaction.scannedBarcode = txt_barcode.Text;
                    int count = db.Transactions.Where(x => x.scannedBarcode.Equals(txt_barcode.Text)).Count();
                    Match m = Regex.Match(txt_barcode.Text, reg);
                    if (count == 0 && m.Success)
                    {
                        transaction.status = "OK";
                        db.Transactions.Add(transaction);
                        db.SaveChanges();
                        ok++;
                        lab_OK.Text = ok.ToString();
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"beep-8.wav");
                        player.Play();
                        txt_barcode.Focus();
                    }
                    else
                    {
                        transaction.status = "NG";
                        if (count > 0)
                        {
                            transaction.note = "Mã vạch đã tồn tại trên hệ thống";
                            lab_erorr.Text = "Mã vạch đã tồn tại trên hệ thống";
                        }
                        else
                        {
                            transaction.note = "Mã vạch không đúng định dạng";
                            lab_erorr.Text = "Mã vạch không đúng định dạng";
                        }
                        db.Transactions.Add(transaction);
                        db.SaveChanges();
                        dgv_NG.Rows.Add(DateTime.Now.ToString(), part, txt_barcode.Text, "NG", lab_erorr.Text);
                        lock_input(false);
                        ng++;
                        lab_NG.Text = ng.ToString();
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"MPS-83-OT-Siren.wav");
                        player.Play();
                    }
                }
                txt_barcode.Text = "";
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            line = comb_line.SelectedValue.ToString();
            reg = comb_part.SelectedValue.ToString();
            part = comb_part.Text;
            txt_barcode.Enabled = true;
            txt_barcode.Focus();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"doorbell.wav");
            player.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
