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

namespace WpfApp4
{ 

    public partial class MainWindow : Window
    {
        string leftop = ""; 
        string operation = ""; 
        string rightop = ""; 

        public MainWindow()
        {
            InitializeComponent();
          
            foreach (UIElement c in Calculate.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string s = (string)((Button)e.OriginalSource).Content;
            
            textBlock.Text += s;
            int num;
           
            bool result = Int32.TryParse(s, out num);
          
            if (result == true)
            {
                
                if (operation == "")
                {
                    
                    leftop += s;
                }
                else
                {
                    
                    rightop += s;
                }
            }
           
            else
            {
                
                if (s == "=")
                {
                    Update_RightOp();
                    textBlock.Text += rightop;
                    operation = "";
                }
               
                else if (s == "CLEAR")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    textBlock.Text = "";
                }
                
                else
                {
                    
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                }
            }
        }
        
        private void Update_RightOp()
        {
            int num1 = Int32.Parse(leftop);
            int num2 = Int32.Parse(rightop);
            
            switch (operation)
            {
                case "+":
                    rightop = (num1 + num2).ToString();
                    break;
                case "-":
                    rightop = (num1 - num2).ToString();
                    break;
                case "*":
                    rightop = (num1 * num2).ToString();
                    break;
                case "/":
                    rightop = (num1 / num2).ToString();
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Click(object sender, RoutedEventArgs e)
        {

        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Not_Clear(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void Answer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажми = ");
        }

        private void Wrong(object sender, RoutedEventArgs e)
        {

        }
    }
}