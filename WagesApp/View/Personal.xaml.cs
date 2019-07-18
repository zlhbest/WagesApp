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
            personlistview.ItemsSource = List;
            departmentlistview.Visibility = Visibility.Hidden;
            wageslistview.Visibility = Visibility.Hidden;
            jobtimelistview.Visibility = Visibility.Hidden;
            ItemsListBox.Items.Add("人员信息表");
            ItemsListBox.Items.Add("人员本月工作时间表");
            ItemsListBox.Items.Add("部门每日工资");
            ItemsListBox.Items.Add("人员工资表");
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
            string tablename = ItemsListBox.SelectedItem.ToString();
            switch (tablename)
            {
                case "人员信息表":
                    PersonalList();
                    break;
                case "人员本月工作时间表":
                    Jobtimelist();
                    break;
                case "部门每日工资":
                    DepartmentList();
                    break;
                case "人员工资表":
                    Wageslist();
                    break;
                default:
                    break;

            }
            MenuToggleButton.IsChecked = false;
        }
        private void PersonalList()
        {
            var List = PersonalControl.GetPeopleFromExcel();
            personlistview.ItemsSource = List;
            personlistview.Visibility = Visibility.Visible;
            wageslistview.Visibility = Visibility.Hidden;
            jobtimelistview.Visibility = Visibility.Hidden;
            departmentlistview.Visibility = Visibility.Hidden;
        }
        private void DepartmentList()
        {
            var List = DepartmentControl.GetDepartmentFromExcel();
            departmentlistview.ItemsSource = List;
            personlistview.Visibility = Visibility.Hidden;
            wageslistview.Visibility = Visibility.Hidden;
            jobtimelistview.Visibility = Visibility.Hidden;
            departmentlistview.Visibility = Visibility.Visible;
           
        }
        private void Jobtimelist()
        {
            var List = PersonalControl.GetPeopleFromExcel();
            jobtimelistview.ItemsSource = List;
            wageslistview.Visibility = Visibility.Hidden;
            departmentlistview.Visibility = Visibility.Hidden;
            personlistview.Visibility = Visibility.Hidden;
            jobtimelistview.Visibility = Visibility.Visible;
        }
        private void Wageslist()
        {
            var List = PersonalControl.GetPeopleFromExcel();
            wageslistview.ItemsSource = List;
            departmentlistview.Visibility = Visibility.Hidden;
            personlistview.Visibility = Visibility.Hidden;
            jobtimelistview.Visibility = Visibility.Hidden;
            wageslistview.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 用于点击单行列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personlistview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person person = personlistview.SelectedItem as Person;
        }

        private void departmentlistview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void jobtimelistview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void wageslistview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
