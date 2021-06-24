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
using какулятор2.other;

namespace какулятор2
{
    public partial class MainWindow : Window
    {
        public static int comma = 0;
        public static int func = 0;
        public static int PorM = 0;
        public static int sw = 0;
        public static string num1 = null;
        public static int lght = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {   
            txbBIG.Text += 0;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text +=  5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 9;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text = null;
            txbSMALL.Text = null;
            comma = 0;
            PorM = 0;
            func = 0;
            num1 = null;

            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btnCE.IsEnabled = true;

            btnEQU.IsEnabled = true;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text = null;
            comma = 0;
            PorM = 0;
        }

        private void btnERASE_Click(object sender, RoutedEventArgs e)
        {
            int lenght = txbBIG.Text.Length - 1;
            string text = txbBIG.Text;
            txbBIG.Text = null;
            for (int i = 0; i < lenght; i++)
            {
                txbBIG.Text += text[i];
            }
        }

        private void btnCOMMA_Click(object sender, RoutedEventArgs e)
        {
            if (comma == 0)
            {
                txbBIG.Text += ",";
                comma = 1;
            }
            
        }

        private void btnDIV_Click(object sender, RoutedEventArgs e)
        {
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                num1 = txbBIG.Text;
                txbSMALL.Text = txbBIG.Text + "%";
                txbBIG.Text = null;
                func = 1;
            }
        }

        private void btnSQRT_Click(object sender, RoutedEventArgs e)
        {
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                num1 = txbBIG.Text;
                txbSMALL.Text = "√" + txbBIG.Text;
                txbBIG.Text = null;
                txbBIG.Text = (Calculate.Sqrt(Convert.ToDouble(num1))).ToString();
                if (txbBIG.Text.Length > 10)
                {
                    string text = txbBIG.Text;
                    txbBIG.Text = null;
                    for (int i = 0; i < 10; i++)
                    {
                        txbBIG.Text += text[i];
                    }
                }
                btn0.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
                btnCE.IsEnabled = false;
                num1 = null;
                btnEQU.IsEnabled = false;
            }
        }

        private void btnPOW_Click(object sender, RoutedEventArgs e)
        {
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                num1 = txbBIG.Text;
                txbSMALL.Text = txbBIG.Text + "^";
                txbBIG.Text = null;
                func = 3;
            }
            
        }

        private void btnFRACT_Click(object sender, RoutedEventArgs e)
        {
            num1 = txbBIG.Text;
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                txbSMALL.Text = "¹/" + txbBIG.Text;
                txbBIG.Text = (Calculate.Fract(Convert.ToDouble(num1))).ToString();
                if (txbBIG.Text.Length > 10)
                {
                    string text = txbBIG.Text;
                    txbBIG.Text = null;
                    for (int i = 0; i < 10; i++)
                    {
                        txbBIG.Text += text[i];
                    }
                }
                btn0.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
                btnCE.IsEnabled = false;
                func = 4;
                num1 = null;
                btnEQU.IsEnabled = false;
            }
         
        }

        private void btnDIVIDE_Click(object sender, RoutedEventArgs e)
        {
            num1 = txbBIG.Text;
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                txbSMALL.Text = txbBIG.Text + "/";
                txbBIG.Text = null;
                func = 5;

            }
        }

        private void btnMULT_Click(object sender, RoutedEventArgs e)
        {
            num1 = txbBIG.Text;
            if ((num1 != string.Empty) && (txbBIG.Text != "-"))
            {
                txbSMALL.Text = txbBIG.Text + "×";
                txbBIG.Text = null;
                func = 6;
            }
        }

        private void btnMINUS_Click(object sender, RoutedEventArgs e)
        {
           
            if (txbBIG.Text == string.Empty)
            {
                txbBIG.Text = "-";
                PorM = 1;
            }
            else if((txbBIG.Text != null) && (txbBIG.Text != "-"))
            {
                num1 = txbBIG.Text;
                if (num1 != string.Empty)
                {
                    txbSMALL.Text = txbBIG.Text + "-";
                    txbBIG.Text = null;
                    func = 7;
                    PorM = 0;
                }
            }
            
        }

        private void btnPLUS_Click(object sender, RoutedEventArgs e)
        {
            num1 = txbBIG.Text;
            if ((num1 != string.Empty)&&(txbBIG.Text != "-"))
            {
                txbSMALL.Text = txbBIG.Text + "+";
                txbBIG.Text = null;
                func = 8;
            }
        }

        private void btnEQU_Click(object sender, RoutedEventArgs e)
        {
            if ((num1 != string.Empty) && (txbBIG.Text != "-")&&(txbBIG.Text != string.Empty))
            {
                if (func == 1)
                {
                    txbSMALL.Text += txbBIG.Text + "=";
                    txbBIG.Text = (Calculate.Div(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
                else if (func == 3)
                {
                    txbSMALL.Text += txbBIG.Text;
                    txbBIG.Text = (Calculate.Pow(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
                else if (func == 5)
                {
                    txbSMALL.Text += txbBIG.Text + "=";
                    txbBIG.Text = (Calculate.Divide(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();
                    if (txbBIG.Text.Length > 10)
                    {
                        string text = txbBIG.Text;
                        txbBIG.Text = null;
                        for (int i = 0; i < 10; i++)
                        {
                            txbBIG.Text += text[i];
                        }
                        
                    }

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
                else if (func == 6)
                {
                    txbSMALL.Text += txbBIG.Text + "=";
                    txbBIG.Text = (Calculate.Multiply(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
                else if (func == 7)
                {
                    txbSMALL.Text += txbBIG.Text + "=";
                    txbBIG.Text = (Calculate.Minus(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
                else if (func == 8)
                {
                    txbSMALL.Text += txbBIG.Text + "=";
                    txbBIG.Text = (Calculate.Plus(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                    num1 = null;
                    btnEQU.IsEnabled = false;
                }
            }
        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (sw == 0)
            {
                btnDIVIDE.Visibility = Visibility.Collapsed;
                btnMULT.Visibility = Visibility.Collapsed;
                btnMINUS.Visibility = Visibility.Collapsed;
                btnPLUS.Visibility = Visibility.Collapsed;

                btnPOW.Visibility = Visibility.Visible;
                btnSQRT.Visibility = Visibility.Visible;
                btnFRACT.Visibility = Visibility.Visible;
                btnDIV.Visibility = Visibility.Visible;

                sw = 1;
            }
            else if (sw == 1)
            {
                btnDIVIDE.Visibility = Visibility.Visible;
                btnMULT.Visibility = Visibility.Visible;
                btnMINUS.Visibility = Visibility.Visible;
                btnPLUS.Visibility = Visibility.Visible;

                btnPOW.Visibility = Visibility.Collapsed;
                btnSQRT.Visibility = Visibility.Collapsed;
                btnFRACT.Visibility = Visibility.Collapsed;
                btnDIV.Visibility = Visibility.Collapsed;

                sw = 0;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.D0)||
                (e.Key == Key.D1)|| 
                (e.Key == Key.D2)|| 
                (e.Key == Key.D3)||
                (e.Key == Key.D4)|| 
                (e.Key == Key.D5)||
                (e.Key == Key.D6)||
                (e.Key == Key.D7)||
                (e.Key == Key.D8)||
                (e.Key == Key.D9))
            {
                string str = e.Key.ToString();
                txbBIG.Text += str[1];
            }
            else if ((e.Key == Key.NumPad0) ||
                     (e.Key == Key.NumPad1) ||
                     (e.Key == Key.NumPad2) ||
                     (e.Key == Key.NumPad3) ||
                     (e.Key == Key.NumPad4) ||
                     (e.Key == Key.NumPad5) ||
                     (e.Key == Key.NumPad6) ||
                     (e.Key == Key.NumPad7) ||
                     (e.Key == Key.NumPad8) ||
                     (e.Key == Key.NumPad9))
                 {
                   string str = e.Key.ToString();
                   txbBIG.Text += str[6];
            }
            else if ((e.Key == Key.OemMinus) || (e.Key == Key.Subtract))
            {
                    btnMINUS_Click(sender, e);
            }
            else if ((e.Key == Key.OemPlus) || (e.Key == Key.Add))
            {
                if (txbBIG.Text != string.Empty)
                {
                    btnPLUS_Click(sender, e);
                }
                
            }
            else if ((e.Key == Key.Divide))
            {
                if (txbBIG.Text != string.Empty)
                {
                    btnDIVIDE_Click(sender, e);
                }
            }
            else if (e.Key == Key.Multiply)
            {
                if (txbBIG.Text != string.Empty)
                {
                    btnMULT_Click(sender, e);
                }
            }
            else if (e.Key == Key.Back)
            {
                if (txbBIG.Text != string.Empty)
                {
                    btnERASE_Click(sender, e);
                }
            }
            else if (e.Key == Key.Decimal)
            {
                if (txbBIG.Text != string.Empty)
                {
                    btnC_Click(sender, e);
                }
            }
            //else if (e.Key == Key.Return)
            //{
            //    btnEQU_Click(sender, e);
            //}
        }

        private void light_Click(object sender, RoutedEventArgs e)
        {
            if (lght == 0)
            {
                MainGrid.Background = Brushes.White;
                titleMane.Foreground = Brushes.LightSlateGray;
                downLine.Background = Brushes.LightSlateGray;

                txbBIG.Foreground = Brushes.LightSlateGray;
                txbSMALL.Foreground = Brushes.LightSlateGray;

                btnCE.Foreground = Brushes.LightSlateGray;
                btnC.Foreground = Brushes.LightSlateGray;
                btnERASE.Foreground = Brushes.LightSlateGray;
                btnDIVIDE.Foreground = Brushes.LightSlateGray;
                btnMULT.Foreground = Brushes.LightSlateGray;
                btnMINUS.Foreground = Brushes.LightSlateGray;
                btnPLUS.Foreground = Brushes.LightSlateGray;
                btnCOMMA.Foreground = Brushes.LightSlateGray;

                btnClose.Foreground = Brushes.LightSlateGray;
                

                lght = 1;
            }
            else if (lght == 1)
            {
                MainGrid.Background = Brushes.Black;
                titleMane.Foreground = Brushes.LightGray;
                downLine.Background = Brushes.LightGray;

                txbBIG.Foreground = Brushes.LightGray;
                txbSMALL.Foreground = Brushes.LightGray;

                btnCE.Foreground = Brushes.White;
                btnC.Foreground = Brushes.White;
                btnERASE.Foreground = Brushes.White;
                btnDIVIDE.Foreground = Brushes.White;
                btnMULT.Foreground = Brushes.White;
                btnMINUS.Foreground = Brushes.White;
                btnPLUS.Foreground = Brushes.White;
                btnCOMMA.Foreground = Brushes.White;

                btnClose.Foreground = Brushes.White;

                lght = 0;
            }
            

        }

        private void txbBIG_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((txbBIG.Text == "-")||(string.IsNullOrEmpty(txbBIG.Text)))
            {
                btn0.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
        }
    }
}
