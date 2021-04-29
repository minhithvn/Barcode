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
    public partial class frmAddFuji : Form
    {
        int id = 0;
        public frmAddFuji()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
        void reset()
        {
            txt_reg.Text = txt_part.Text = "";
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            id = 0;
            using (ModelContext db = new ModelContext())
            {
                dgv_Fuji.DataSource = db.FujiParts.ToList();
            }
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (db.FujiParts.Where(x => x.name.Equals(txt_part.Text.Trim())).Count() > 0 || txt_part.Text.Trim().Length == 0 || txt_reg.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    FujiPart fujiPart = new FujiPart();
                    fujiPart.name = txt_part.Text.Trim();
                    fujiPart.reg = txt_reg.Text.Trim();
                    db.FujiParts.Add(fujiPart);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    reset();
                }

            }
        }

        private void frmAddFuji_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (txt_part.Text.Trim().Length == 0 || txt_reg.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    FujiPart fujiPart = new FujiPart();
                    fujiPart.id = id;
                    fujiPart.name = txt_part.Text.Trim();
                    fujiPart.reg = txt_reg.Text.Trim();
                    db.Entry(fujiPart).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    reset();
                }

            }
        }

        private void dgv_Fuji_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Fuji.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgv_Fuji.CurrentRow.Cells[0].Value);
                txt_part.Text = dgv_Fuji.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_reg.Text = dgv_Fuji.CurrentRow.Cells[2].Value.ToString().Trim();
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm?", "xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    FujiPart fujiPart = new FujiPart();
                    fujiPart = db.FujiParts.Where(x => x.id == id).ToList().First();
                    db.FujiParts.Remove(fujiPart);
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
    }
}
