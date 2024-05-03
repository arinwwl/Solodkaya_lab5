using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Solodkaya_lab5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private void CheckPalindrome_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Number1TextBox.Text, out int number1) && int.TryParse(Number2TextBox.Text, out int number2))
            {
                if (IsPalindrome(number1) || IsPalindrome(number2))
                {
                    ResultText.Text = "Хотя бы одно из чисел является палиндромом.";
                }
                else
                {
                    ResultText.Text = "Ни одно из чисел не является палиндромом.";
                }
            }
            else
            {
                ResultText.Text = "Ошибка ввода. Пожалуйста, введите натуральные числа.";
            }
        }
    }
}
