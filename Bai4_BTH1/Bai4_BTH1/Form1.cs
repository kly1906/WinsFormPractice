using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai4_BTH1
{
    public partial class frmOperation : Form
    {
        static double result;

        public frmOperation()
        {
            InitializeComponent();
        }

        private void lblNumber2_Click(object sender, EventArgs e)
        {

        }

        private void frmOperation_Load(object sender, EventArgs e)
        {

        }

        private void grbOperation_Enter(object sender, EventArgs e)
        {

        }

        //thực hiện phép cộng
        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length == 0 || txtNum2.Text.Length == 0)
            {
                MessageBox.Show("Nhập số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                result = Double.Parse(txtNum1.Text) + Double.Parse(txtNum2.Text);
                txtResult.Text = result.ToString();
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //chỉ cho phép nhập số và xóa khi nhập sai
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //chỉ cho phép nhập số và xóa khi nhập sai
            }
        }

        //thực hiện phép trừ
        private void rdbSub_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length == 0 || txtNum2.Text.Length == 0)
            {
                MessageBox.Show("Nhập số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                result = Double.Parse(txtNum1.Text) - Double.Parse(txtNum2.Text);
                txtResult.Text = result.ToString();
            }
        }

        //thực hiện phép nhân
        private void rdbMul_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length == 0 || txtNum2.Text.Length == 0)
            {
                MessageBox.Show("Nhập số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                result = Double.Parse(txtNum1.Text) * Double.Parse(txtNum2.Text);
                txtResult.Text = result.ToString();
            }
        }

        //thực hiện phép chia
        private void rdbDiv_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length == 0 || txtNum2.Text.Length == 0)
            {
                MessageBox.Show("Nhập số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (txtNum2.Text != "0")
                {
                    result = Double.Parse(txtNum1.Text) / Double.Parse(txtNum2.Text);
                    txtResult.Text = result.ToString();
                }
                else
                {
                    txtResult.Text = "Không thể thực hiện";
                }    
            }
        }
    }
}