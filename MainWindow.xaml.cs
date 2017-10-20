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

namespace Labb5
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserBox.Items.Add(new User { name = NameBox.Text, email = MailBox.Text });
            UserBox.DisplayMemberPath = "name";
        }
        private void UserBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddToAdminList.IsEnabled = UserBox.SelectedIndex >= 0;
            RemoveUser.IsEnabled = UserBox.SelectedIndex >= 0;

            UserInfo.Content = "Name: " + ((User)UserBox.SelectedItem).name + "\nEmail: " + ((User)UserBox.SelectedItem).email;

        }

        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            if (UserBox.SelectedIndex >= 0)
            {
                int position = UserBox.SelectedIndex;
                UserBox.Items.RemoveAt(position);
                if (UserBox.Items.Count <= position)
                    UserBox.SelectedIndex = position - 1;
                else
                    UserBox.SelectedIndex = position;
                if (UserBox.Items.Count == 0)
                    RemoveUser.IsEnabled = false;
            }
        }

        private void AddToAdminList_Click(object sender, RoutedEventArgs e)
        {
            if (UserBox.SelectedIndex >= 0)
            {
                int position = UserBox.SelectedIndex;
                UserBox.Items.RemoveAt(position);
                if (UserBox.Items.Count <= position)
                    UserBox.SelectedIndex = position - 1;
                else
                    UserBox.SelectedIndex = position;
                if (UserBox.Items.Count == 0)
                    AddToAdminList.IsEnabled = false;
            }
            AdminBox.Items.Add(UserBox.SelectedItem);
            UserBox.Items.Remove(UserBox.SelectedItem);
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public User()
        {
        }
    }
}
