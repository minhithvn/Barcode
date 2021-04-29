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
    public partial class frmCanonPart : Form
    {
        int id = 0;
        public frmCanonPart()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (db.CanonParts.Where(x => x.name.Equals(txt_part.Text.Trim())).Count() > 0 || txt_part.Text.Trim().Length == 0 || txt_barcode.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    CanonPart canonPart = new CanonPart();
                    canonPart.name = txt_part.Text.Trim();
                    canonPart.code = txt_barcode.Text.Trim();
                    db.CanonParts.Add(canonPart);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    reset();
                }

            }
        }
        void reset()
        {
            txt_barcode.Text = txt_part.Text ="";
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            id = 0;
            using (ModelContext db = new ModelContext())
            {
                dgv_Canon.DataSource = db.CanonParts.ToList();
            }
        }

        private void dgv_Canon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Canon.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgv_Canon.CurrentRow.Cells[0].Value);
                txt_part.Text = dgv_Canon.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_barcode.Text = dgv_Canon.CurrentRow.Cells[2].Value.ToString().Trim();
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (db.CanonParts.Where(x => x.name.Equals(txt_part.Text.Trim())).Count() > 0 || txt_part.Text.Trim().Length == 0 || txt_barcode.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    CanonPart canonPart = new CanonPart();
                    canonPart.id = id;
                    canonPart.name = txt_part.Text.Trim();
                    canonPart.code = txt_barcode.Text.Trim();
                    db.Entry(canonPart).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    reset();
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm?", "xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    CanonPart canonPart = new CanonPart();
                    canonPart = db.CanonParts.Where(x => x.id == id).ToList().First();
                    db.CanonParts.Remove(canonPart);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    reset();
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void frmCanonPart_Load(object sender, EventArgs e)
        {
            reset();
        }
    }
}
