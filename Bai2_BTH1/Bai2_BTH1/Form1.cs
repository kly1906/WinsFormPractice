using System.Runtime.CompilerServices;

namespace Bai2_BTH1
{
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFont_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            while (this.txtName.Text.Length == 0)
            {
                txtName.Focus();
                return;
            }

            if (!rdbLower.Checked && !rdbUpper.Checked)
            {
                MessageBox.Show("Vui lòng chọn kiểu chữ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdbLower.Checked)
            {
                txtResult.Text = txtName.Text.ToLower();
            }
            else
            {
                txtResult.Text = txtName.Text.ToUpper();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtName.Focus();
        }
    }
}