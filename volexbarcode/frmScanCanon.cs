using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class frmScanCanon : Form
    {
        int ok = 0; //đếm số lượng OK
        int ng = 0; // đếm số lượng NG
        string line = "";
        string code = "";
        string part = "";
        DateTime start = DateTime.Now;
        DateTime end = DateTime.Now;
        bool play_flag = true;
        public frmScanCanon()
        {
            InitializeComponent();
        }

        private void frmScanCanon_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                comb_line.DataSource = db.Lines.ToList();
                comb_line.DisplayMember = "name";
                comb_line.ValueMember = "name";
   
                comb_part.DataSource = db.CanonParts.ToList();
                comb_part.DisplayMember = "name";
                comb_part.ValueMember = "code";

            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            line = comb_line.SelectedValue.ToString();
            code = comb_part.SelectedValue.ToString();
            part = comb_part.Text;
            txt_barcode.Enabled = true;
            txt_barcode.Focus();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"doorbell.wav");
            player.Play();
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start = end;
                end = DateTime.Now;
                try
                {
                    using (ModelContext db = new ModelContext())
                    {
                        Transaction transaction = new Transaction();
                        transaction.line = line;
                        transaction.partName = part;
                        transaction.scannedBarcode = txt_barcode.Text;
                        if (txt_barcode.Text == code)
                        {
                            transaction.status = "OK";
                            if (chk_repeat.Checked)
                            {
                                if ((end - start).TotalSeconds > Convert.ToDouble(txt_repeat.Text))
                                {
                                    db.Transactions.Add(transaction);
                                    db.SaveChanges();
                                }
                            }
                            else
                            {
                                db.Transactions.Add(transaction);
                                db.SaveChanges();
                            }


                            ok++;
                            lab_OK.Text = ok.ToString();
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"beep-8.wav");
                            player.Play();
                            txt_barcode.Focus();
                        }
                        else
                        {
                            transaction.status = "NG";
                            db.Transactions.Add(transaction);
                            db.SaveChanges();
                            lab_erorr.Text = "Sai mã vạch !!!";
                            dgv_NG.Rows.Add(end.ToString(), part, txt_barcode.Text, "NG");
                            lock_input(false);
                            ng++;
                            lab_NG.Text = ng.ToString();
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"MPS-83-OT-Siren.wav");
                            player.Play();
                        }

                    }
                } catch (SqlException ex)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"false_alarm.wav");
                    player.Play();
                    MessageBox.Show("Lỗi kết nối mạng!!!");
                }

                
                txt_barcode.Text = "";
            }
        }

        void lock_input(bool flag)
        {
            txt_barcode.Enabled = comb_line.Enabled = comb_part.Enabled = btn_start.Enabled = chk_repeat.Enabled = txt_repeat.Enabled = flag;
            txt_password.Enabled = btn_unlock.Enabled = lab_erorr.Visible = !flag;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"doorbell.wav");
            player.Play();
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "volex")
            {
                lock_input(true);
                txt_repeat.Enabled = chk_repeat.Checked;
                txt_password.Text = "";
                txt_barcode.Focus();
            }
        }

        private void chk_repeat_CheckedChanged(object sender, EventArgs e)
        {
            txt_repeat.Enabled = !txt_repeat.Enabled;
        }
    }
}
