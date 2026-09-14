using System;
using System.Windows.Forms;

namespace Câu14
{
    public partial class frmCapNhat2ListBox : Form
    {
        public frmCapNhat2ListBox()
        {
            InitializeComponent();
        }

        // ==========================================
        // 1. NÚT CẬP NHẬT
        // ==========================================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show(
                    "Bạn không được phép nhập dữ liệu rỗng!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;

                // Thêm dữ liệu vào Lớp A
                lstLopA.Items.Add(strDuLieu);

                // Xóa TextBox
                txtTen.Clear();

                // Đưa con trỏ về TextBox
                txtTen.Focus();
            }
        }


        // ==========================================
        // 2. HÀM CHUYỂN CÁC PHẦN TỬ ĐƯỢC CHỌN
        // ==========================================
        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;

            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();

                    // Thêm sang ListBox bên kia
                    lst2.Items.Add(stDuLieu);

                    // Xóa khỏi ListBox hiện tại
                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }


        // ==========================================
        // 3. NÚT >
        // Chuyển phần tử được chọn từ A sang B
        // ==========================================
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 4. NÚT <
        // Chuyển phần tử được chọn từ B sang A
        // ==========================================
        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 5. HÀM CHUYỂN TOÀN BỘ
        // ==========================================
        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();

                // Thêm sang ListBox bên kia
                lst2.Items.Add(stDuLieu);

                // Xóa phần tử đầu tiên
                lst1.Items.RemoveAt(0);
            }
        }


        // ==========================================
        // 6. NÚT >>
        // Chuyển toàn bộ A sang B
        // ==========================================
        private void btnSangHetPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 7. NÚT <<
        // Chuyển toàn bộ B sang A
        // ==========================================
        private void btnSangHetTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Danh sách hiện đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 8. HÀM XÓA CÁC PHẦN TỬ ĐƯỢC CHỌN
        // ==========================================
        void xoaDuLieu(ListBox lst)
        {
            int i = 0;

            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }


        // ==========================================
        // 9. NÚT XÓA LỚP A
        // ==========================================
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show(
                    "Hiện danh sách đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 10. NÚT XÓA LỚP B
        // ==========================================
        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show(
                    "Hiện danh sách đang rỗng!",
                    "Chú ý"
                );
            }
        }


        // ==========================================
        // 11. NÚT KẾT THÚC
        // ==========================================
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ==========================================
        // 12. XỬ LÝ KHI ĐÓNG FORM
        // ==========================================
        private void frmCapNhat2ListBox_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}