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
using System.Windows.Shapes;

namespace trevel
{
    /// <summary>
    /// Логика взаимодействия для ViewingTask.xaml
    /// </summary>
    public partial class ViewingTask : Window
    {
        public ViewingTask()
        {
            InitializeComponent();
            LoadData();

        }
        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            new cabinet().Show();
            this.Close();
        }
        private void LoadData()
        {
            TaskDGrid.ItemsSource = Helper.db.Tasks.ToList();
        }
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = Helper.db.Users.FirstOrDefault(q => q.Login == LoginBox.Text);
            if (user != null)
            {
                Task task = Helper.db.Tasks.FirstOrDefault(t => t.IdOwner == user.Id);
                new SearchUser(task).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
        private void TaskDGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task select = TaskDGrid.SelectedItem as Task;
            Helper.task = select;
            new TaskWindow(select).Show();
            this.Close();
        }
    }
}
