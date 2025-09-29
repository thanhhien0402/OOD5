using System;
using System.Windows.Forms;

namespace NguyenThiThanhHien_1150080092_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool LayDuLieu(out double a, out double b)
        {
            try
            {
                a = Convert.ToDouble(txtSoA.Text.Trim());
                b = Convert.ToDouble(txtSoB.Text.Trim());
                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                a = b = 0;
                return false;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
                txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
                txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
                txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi tính toán",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtKetQua.Text = (a / b).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoA.Clear();
            txtSoB.Clear();
            txtKetQua.Clear();
            txtSoA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
