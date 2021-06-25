using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int comma = 0;
        public static int func = 0;
        public static int PorM = 0;
        public static int sw = 0;
        public static string num1 = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 0;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 1;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 2;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 3;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 4;
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 5;
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 6;
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 7;
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 8;
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text += 9;
        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text = null;
            txtsmTablo.Text = null;
            comma = 0;
            PorM = 0;
            func = 0;

            B0.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;
            BCE.IsEnabled = true;
        }

        private void BCE_Click(object sender, RoutedEventArgs e)
        {
            int lenght = txtTablo.Text.Length - 1;
            string text = txtTablo.Text;
            txtTablo.Text = null;
            for (int i = 0; i < lenght; i++)
            {
                txtTablo.Text += text[i];
            }
        }

        private void btnCOMMA_Click(object sender, RoutedEventArgs e)
        {
            if (comma == 0)
            {
                txtTablo.Text += ",";
                comma = 1;
            }

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            num1 = txtTablo.Text;
            txtsmTablo.Text = txtTablo.Text + "%";
            txtTablo.Text = null;
            func = 1;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            num1 = txtTablo.Text;
            txtsmTablo.Text = txtTablo.Text + "/";
            txtTablo.Text = null;
            func = 2;
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            num1 = txtTablo.Text;
            txtsmTablo.Text = txtTablo.Text + "*";
            txtTablo.Text = null;
            func = 3;
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {

            if (txtTablo.Text == string.Empty)
            {
                txtTablo.Text = "-";
                PorM = 1;
            }
            else if ((txtTablo.Text != null) && (txtTablo.Text != "-"))
            {
                num1 = txtTablo.Text;
                txtsmTablo.Text = txtTablo.Text + "-";
                txtTablo.Text = null;
                func = 4;
                PorM = 0;
            }

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = txtTablo.Text;
            txtsmTablo.Text = txtTablo.Text + "+";
            txtTablo.Text = null;
            func = 5;

        }

        private void btnEqu_Click(object sender, RoutedEventArgs e)
        {

            if (func == 1)
            {
                txtsmTablo.Text += txtTablo.Text + "=";
                txtTablo.Text = Calculation.Div(Convert.ToDouble(num1), Convert.ToDouble(txtTablo.Text)).ToString();
            }
            else if (func == 2)
            {
                txtsmTablo.Text += txtTablo.Text + "=";
                txtTablo.Text = Calculation.Division(Convert.ToDouble(num1), Convert.ToDouble(txtTablo.Text)).ToString();
                if (txtTablo.Text.Length > 10)
                {
                    string text = txtTablo.Text;
                    txtTablo.Text = null;
                    for (int i = 0; i < 10; i++)
                    {
                        txtTablo.Text += text[i];
                    }
                }
            }
            else if (func == 3)
            {
                txtsmTablo.Text += txtTablo.Text + "=";
                txtTablo.Text = Calculation.Mul(Convert.ToDouble(num1), Convert.ToDouble(txtTablo.Text)).ToString();
            }
            else if (func == 4)
            {
                txtsmTablo.Text += txtTablo.Text + "=";
                txtTablo.Text = Calculation.Minus(Convert.ToDouble(num1), Convert.ToDouble(txtTablo.Text)).ToString();
            }
            else if (func == 5)
            {
                txtsmTablo.Text += txtTablo.Text + "=";
                txtTablo.Text = Calculation.Plus(Convert.ToDouble(num1), Convert.ToDouble(txtTablo.Text)).ToString();
            }
        }
    }
}
