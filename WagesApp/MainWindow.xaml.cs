using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WagesApp.Control;
using WagesApp.View;

namespace WagesApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnCopy(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter is string stringValue)
            {
                try
                {
                    Clipboard.SetDataObject(stringValue);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameTextBox.Text.ToString();
            string Password = PasswordBox.Password.ToString();
            if(Name == "" || Password == "")
            {
                //message.Foreground = new Brush(Color.FromRgb(255,0,0)) ; //设置前景色，即字体颜色
                message.Content = "密码或者账号不能为空";
                //MessageBox.Show("密码或者账号不能为空");
            }
            else
            {
                if(adminControl.login(Name, Password))
                {
                    Personal personal = new Personal();
                    personal.ShowDialog();
                }
                else
                {
                    message.Content = "密码或者账号错误";
                }
            }
        }
    }
}
