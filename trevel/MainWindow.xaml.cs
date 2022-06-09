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

namespace trevel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Helper();
        }
        private void Button_Red_Click(object sender, RoutedEventArgs e)
        {
            string LastName = textBoxLastName.Text.Trim();
            string FristName = textBoxFirstName.Text.Trim();
            string SecondName = textBoxSecondName.Text.Trim();

            string Login = textBoxLogin.Text.Trim();
            string Pass = passBox.Password.Trim();
            string Pass_2 = passBox_2.Password.Trim();
            string Phone = textBoxPhone.Text.Trim();


            if (FristName.Length < 5)
            {
                textBoxFirstName.ToolTip = "Фамилия введена не правильно!";
                textBoxFirstName.Background = Brushes.DarkGoldenrod;
            }
            else if (LastName.Length < 5)
            {
                textBoxLastName.ToolTip = "Имя введино не правильно !";
                textBoxLastName.Background = Brushes.DarkGoldenrod;
            }

            else if (SecondName.Length < 5)
            {
                textBoxSecondName.ToolTip = "Логин введен не правильно!";
                textBoxSecondName.Background = Brushes.DarkGoldenrod;
            }
            else if (Phone.Length < 11)
            {
                textBoxPhone.ToolTip = "Имя введино не правильно !";
                textBoxPhone.Background = Brushes.DarkGoldenrod;
            }


            else if (Login.Length < 5)
            {
                textBoxLogin.ToolTip = "Логин введен не правильно!";
                textBoxLogin.Background = Brushes.DarkGoldenrod;
            }
            else if (Pass.Length < 5)
            {
                passBox.ToolTip = "Пароль введен не правильно!";
                passBox.Background = Brushes.DarkGoldenrod;

            }
            else if (Pass != Pass_2)
            {
                passBox_2.ToolTip = "Пароль введен не правильно!";
                passBox_2.Background = Brushes.DarkGoldenrod;

            }

            else
            {

                textBoxFirstName.ToolTip = "";
                textBoxFirstName.Background = Brushes.Transparent;

                textBoxLastName.ToolTip = "";
                textBoxLastName.Background = Brushes.Transparent;

                textBoxSecondName.ToolTip = "";
                textBoxSecondName.Background = Brushes.Transparent;

                textBoxPhone.ToolTip = "";
                textBoxPhone.Background = Brushes.Transparent;

                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;

                textBoxPhone.ToolTip = "";
                textBoxPhone.Background = Brushes.Transparent;


                MessageBox.Show("Все хорошо!");

                User user = new User()
                {
                    FirstName = FristName,
                    LastName = LastName,
                    SecondName = SecondName,
                    Phone = Phone,
                    Login = Login,
                    Pass = Pass,
                };



                Helper.db.Users.Add(user);
                Helper.db.SaveChanges();

                Entrance Taskwindow = new Entrance();
                Taskwindow.Show();
                this.Close();
            }
        }
        private void Button_Entrance_Click(object sender, RoutedEventArgs e)
        {
            Entrance Taskwindow = new Entrance();
            Taskwindow.Show();
            this.Close();
        }
    }
}