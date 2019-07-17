using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WagesApp.Control;
using WagesApp.Model;

namespace WagesApp.View
{
    /// <summary>
    /// Pershona_.xaml 的交互逻辑
    /// </summary>
    public partial class Personal : Window
    {
        public Personal()
        {
            InitializeComponent();
            var List = PersonalControl.GetPeopleFromExcel();
            person.ItemsSource = List;
            ItemsListBox.Items.Add("点击");
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

        private void ItemsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(ItemsListBox.SelectedItem.ToString());
        }
    }
}
