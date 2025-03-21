using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_DangNhap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] user = { "admin1", "admin2", "admin3" };       
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                epuser.SetError(txtTen, "vui long nhap ten dang nhap");
                txtTen.Focus();
                return;
            }

            for (int i = 0; i < user.Length; i++)
            {
                if (txtTen.Text == user[i])
                {

                }
                else
                {
                    epuser.SetError(txtTen, "tài khoản của bạn không tồn tại");
                    txtTen.Text = "";
                    txtTen.Focus();
                    return;
                }
                epuser.Clear();
                if (txtTen.Text != user[i])
                {
                    epuser.SetError(txtTen, "sai ten dang nhap ");
                    txtTen.Text = "";
                    txtTen.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("sai mat khau hoac tai khoan", "loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
              
            }
            
            if (txtTen.Text != "khoa")
            {
                epuser.SetError(txtTen, "sai ten dang nhap ");
                txtTen.Text = "";
                txtTen.Focus();
                return;
            }
           

            else
            {
                MessageBox.Show("sai mat khau hoac tai khoan", "loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            epuser.Clear();
            if (string.IsNullOrEmpty(Txtmk.Text))
            {
                epuser.SetError(Txtmk, "vui long nhap mat khau");
                Txtmk.Focus();
                return;
            }
            if (Txtmk.Text != "123")
            {
                epuser.SetError(Txtmk, "sai mat khau ");
                Txtmk.Text = "";
                Txtmk.Focus();
                return;
            }
            if (txtTen.Text == "khoa" && Txtmk.Text == "123")
            {
                MainLogin dangNhap = new MainLogin();
                this.Hide();
                dangNhap.ShowDialog();
                DangNhap main = new DangNhap();
                Close();
            }

            else
            {
                MessageBox.Show("sai mat khau hoac tai khoan", "loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            

            void login()
            {
               MainLogin dangNhap = new MainLogin();
                this.Hide();
                dangNhap.ShowDialog();
                DangNhap main = new DangNhap();
                Close();
                
            }
            
        }

            private void Txtmk_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }


