using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai3_BTH3
{
    public partial class frmcbb : Form
    {
        public frmcbb()
        {
            InitializeComponent();
        }

        //sự kiện click của button cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //nếu textbox trống, đặt con trỏ vào textbox
            if (this.txtInput.Text.Length == 0)
            {
                txtInput.Focus();
                return; //kết thúc sự kiện click
            }

            int number;
            if (int.TryParse(txtInput.Text, out number))
            {
                //nếu nội dung textbox là số nguyên
                //hiển thị số mới nhập trên thanh combobox, thêm vào vị trí đầu tiên 
                cbbUpdate.Text = txtInput.Text;
                cbbUpdate.Items.Insert(0, txtInput.Text);
                UpdateDivisorsList();//hiển thị danh sách ước của số nguyên vừa nhập
                //xóa nội dung textbox vừa nhập và đặt con trỏ trở lại textbox
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                //nếu không phải số nguyên, hiển thị thông báo 
                MessageBox.Show("Vui lòng nhập một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }

        }

        private void cbbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDivisorsList(); //hiển thị ước của số nguyên được chọn
        }

        //phương thức tính các ước của số nguyên
        private List<int> GetDivisors(int number)
        {
            List<int> divisors = new List<int>();

            // Tính toán các ước số của số nguyên
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        //phương thức hiển thị các ước ra listbox
        private void UpdateDivisorsList()
        {
            int selectedNumber = int.Parse(cbbUpdate.Text);

            //tính toán các ước của số nguyên
            List<int> divisors = GetDivisors(selectedNumber);
            //xóa nội dung cũ và hiện thị nội dung mới ra listbox
            lstDivisor.Items.Clear();
            foreach (int divisor in divisors)
            {
                lstDivisor.Items.Add(divisor);
            }
        }

        //tính tổng các ước 
        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (lstDivisor.Items.Count > 0)
            {
                foreach (int divisor in lstDivisor.Items)
                {
                    sum += divisor;
                }
                MessageBox.Show($"Tổng các ước: {sum}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //đếm số ước chẵn
        private void btntEven_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (lstDivisor.Items.Count > 0)
            {
                foreach (int divisor in lstDivisor.Items)
                {
                    if (divisor % 2 == 0)
                    {
                        count += divisor;
                    }
                }
                MessageBox.Show($"Tổng các ước: {count}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //đếm số ước nguyên tố
        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool check = false;
            if (lstDivisor.Items.Count > 0)
            {
                foreach (int divisor in lstDivisor.Items)
                { 
                    if (IsPrime(divisor) == true)
                    {
                        count++;
                    }
                }

                MessageBox.Show($"Tổng các ước: {count}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //phương thức kiểm tra số nguyên tố
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false; //Số nhỏ hơn hoặc bằng 1 không phải là số nguyên tố

            if (number == 2)
                return true; //2 là số nguyên tố

            if (number % 2 == 0)
                return false; //Các số chẵn khác 2 không phải là số nguyên tố

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false; //Nếu chia hết cho số lẻ khác 1 thì không phải số nguyên tố
            }

            return true; //Số không chia hết cho bất kỳ số nào khác ngoài 1 và chính nó là số nguyên tố
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}