namespace Bai1_BTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            while (txtUser.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                if(txtPass.Text.Length == 0)
                {
                    txtUser.Focus();
                    return;
                }
                else
                {
                    txtPass.Focus();
                    return;
                }
            }    
            string Notification = "Tên đăng nhập: " + txtUser.Text + "\nMật khẩu: " + txtPass.Text;
            if (this.chkRemember.Checked == true)
            {
                MessageBox.Show(Notification + "\nBạn có ghi nhớ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Notification, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Xóa toàn bộ nội dung đã nhập trong text box
            this.txtUser.Clear();
            this.txtPass.Clear();

            //đặt tiêu điểm vào textbox tên đăng nhập sau khi reset
            this.txtUser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Dừng chương trình và đóng tất cả form
            Application.Exit();
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}