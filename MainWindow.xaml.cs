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
            UserBox.DisplayMemberPath = "name";
            AdminBox.DisplayMemberPath = "name";
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserBox.Items.Add(new User { name = NameBox.Text, email = MailBox.Text });

            NameBox.Text = "Enter name...";
            MailBox.Text = "Enter email adress...";
        }

        private void UserBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserBox.SelectedItem != null)
            {
                AddToAdminList.IsEnabled = UserBox.SelectedIndex >= 0;
                RemoveUser.IsEnabled = UserBox.SelectedIndex >= 0;

                if (UserBox.SelectedIndex < 0)
                {
                    UserInfo.Content = " ";
                }
                else
                {
                    UserInfo.Content = "Name: " + ((User)UserBox.SelectedItem).name + "\nEmail: " + ((User)UserBox.SelectedItem).email;
                }

                NameBox.Text = ((User)UserBox.SelectedItem).name;
                MailBox.Text = ((User)UserBox.SelectedItem).email;
            }
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
                AdminBox.Items.Add((User)UserBox.SelectedItem);
                UserBox.Items.RemoveAt(position);
                if (UserBox.Items.Count <= position)
                    UserBox.SelectedIndex = position - 1;
                else
                    UserBox.SelectedIndex = position;
                if (UserBox.Items.Count == 0)
                    AddToAdminList.IsEnabled = false;
            }
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {

        } //slutade fungera.

        private void ChangeUser_Click_1(object sender, RoutedEventArgs e)
        {
            int index = UserBox.SelectedIndex;
            UserBox.Items.RemoveAt(UserBox.SelectedIndex);
            UserBox.Items.Insert(index, (new User { name = NameBox.Text, email = MailBox.Text }));
            //UserBox.SelectedItem = (new User { name = NameBox.Text, email = MailBox.Text });

        }

        private void NameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            NameBox.Text = string.Empty;
        }

        private void MailBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MailBox.Text = string.Empty;
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

