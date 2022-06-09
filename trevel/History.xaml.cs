using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Window
    {
        public History()
        {
            InitializeComponent();
            User history = new User();
            history = Helper.userSession;
            DataContext = history;
            LoadChangedDate();
        }
        private void LoadChangedDate()
        {
            ReadyTask.ItemsSource = Helper.db.Tasks.Where(t => t.IdWorker == Helper.userSession.Id && t.IdStatusTask == 2).Include(s => s.IdStatusTaskNavigation).ToList();
        }

        private void ReadyTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task task = ReadyTask.SelectedItem as Task;
            if (task != null)
            {
                task.IdStatusTask = 2;
                Helper.db.SaveChanges();
                LoadChangedDate();
            }
            ReadyTask.SelectedItem = null;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new cabinet().Show();
            this.Close();
        }
    }
}

