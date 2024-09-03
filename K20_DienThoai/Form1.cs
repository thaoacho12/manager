using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K20_DienThoai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Xoá dữ liệu ở các textbox
        public void clearTextBox()
        {
            foreach (TextBox txt in this.panel2.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    txt.Text = null;
                }
            }
        }
        //Kiểm tra các textbox phải có dữ liệu
        public bool checkTextBox()
        {
            foreach(TextBox txt in this.panel2.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(txt.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = KetNoi.getData(null, true);
        }

        private void btnNhapDL_Click(object sender, EventArgs e)
        {
            bool themDT = true;//biến kiểm tra xem đang là thêm DL hay sửa DL
            if (!btnNhapDL.Text.Equals("Thêm DL"))
                themDT = false;
            if (checkTextBox())
            {
                DienThoai dienThoai = new DienThoai(txtMaDT.Text, txtTenDT.Text, txtHangSX.Text, txtThongTin.Text, int.Parse(txtGia.Text));
                if (KetNoi.Them_SuaDT(dienThoai,themDT))
                {
                    MessageBox.Show(btnNhapDL.Text+" thành công", "Thông báo");
                    dgvHienThi.DataSource = KetNoi.getData(null, true);
                    if (!themDT)
                    {
                        txtMaDT.Enabled = true;
                        btnNhapDL.Text = "Thêm DL";
                        clearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo");
                }
            }
            else
                MessageBox.Show("Bạn phải nhập đủ DL", "Thông báo");

        }

        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.CurrentRow != null)
            {
                int i = dgvHienThi.CurrentRow.Cells.Count-1;
                foreach (TextBox txt in this.panel2.Controls.OfType<TextBox>())
                {
                    txt.Text = dgvHienThi.CurrentRow.Cells[i].Value.ToString();
                    i--;
                }
                btnNhapDL.Text = "Sửa DL";
                txtMaDT.Enabled = false;
            }
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.CurrentRow != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn thật sự muốn xoá?", "Thông Báo", MessageBoxButtons.YesNo))
                {

                    if (KetNoi.XoaDT(dgvHienThi.CurrentRow.Cells["MaDT"].Value.ToString()))
                    {
                        MessageBox.Show("Xoá thành công.", "Thông báo");
                        dgvHienThi.DataSource = KetNoi.getData(null,true);
                    }
                    else
                        MessageBox.Show("Lỗi.", "Thông báo");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = KetNoi.getData(txtTimKiem.Text, rbtTenDT.Checked);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearTextBox();
            txtMaDT.Enabled = true;
            btnNhapDL.Text = "Thêm DL";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
