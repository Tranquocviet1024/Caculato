using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ tạm thời các giá trị
        string input = string.Empty;        // Chuỗi chứa giá trị nhập vào
        string operand1 = string.Empty;     // Số hạng thứ nhất
        string operand2 = string.Empty;     // Số hạng thứ hai
        char operation;                     // Phép toán (+, -, *, /)
        double result = 0.0;                // Kết quả tính toán

        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý khi nhấn các nút số
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        // Xử lý khi nhấn các nút phép toán (+, -, *, /)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(button.Text);
            input = string.Empty;
        }

        // Xử lý khi nhấn nút "=" để tính toán
        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                    }
                    break;
            }

            textBox1.Text = result.ToString();
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        // Xử lý khi nhấn nút "C" để xóa tất cả
        private void btnClear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            textBox1.Text = "0";
        }
    }
}
