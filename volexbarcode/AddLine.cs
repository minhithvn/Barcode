using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using volexbarcode.Model;

namespace volexbarcode
{
    public partial class AddLine : Form
    {
        int id = 0;
        public AddLine()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                if (db.Lines.Where(x=> x.name.Equals(txt_line.Text.Trim())).Count() > 0 || txt_line.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Dây chuyền đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    Line line = new Line();
                    line.name = txt_line.Text.Trim();
                    db.Lines.Add(line);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    reset();
                }

            }
        }

        private void AddLine_Load(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            txt_line.Text = "";
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            id = 0;
            using(ModelContext db = new ModelContext())
            {
                dgv_Line.DataSource = db.Lines.ToList();
            }
        }

        private void dgv_Line_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                if (db.Lines.Where(x => x.name.Equals(txt_line.Text.Trim())).Count() > 0 || txt_line.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Dây chuyền đã tồn tại hoặc không hợp lệ, vui lòng chọn tên khác!");
                }
                else
                {
                    Line line = new Line();
                    line.id = id;
                    line.name = txt_line.Text.Trim();
                    db.Entry(line).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    reset();
                }

            }
        }

        private void dgv_Line_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Line.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgv_Line.CurrentRow.Cells[0].Value);
                txt_line.Text = dgv_Line.CurrentRow.Cells[1].Value.ToString().Trim();
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dây chuyền?","xóa dây chuyền",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(ModelContext db = new ModelContext())
                {
                    Line line = new Line();
                    line = db.Lines.Where(x => x.id == id).ToList().First();
                    db.Lines.Remove(line);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    reset();
                }
            }

        }
    }
}
