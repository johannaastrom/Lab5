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
using System.Text.RegularExpressions;

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
            bool isEmail = Regex.IsMatch(MailBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (isEmail)
                UserBox.Items.Add(new User { name = NameBox.Text, email = MailBox.Text });
            else
            {
                UserInfo.Content = "Invalid email adress";
            }

            NameBox.Text = "Enter name...";
            MailBox.Text = "Enter email adress...";
        }

        private void UserBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var userName = ((User)UserBox.SelectedItem);
            var userMail = ((User)UserBox.SelectedItem);
            if (UserBox.SelectedItem != null)
            {
                AddToAdminList.IsEnabled = UserBox.SelectedIndex >= 0;
                RemoveUser.IsEnabled = UserBox.SelectedIndex >= 0;

                if (UserBox.SelectedIndex >= 0)
                {
                    UserInfo.Content = "Full information about the selected person:\n\nName: " + ((User)UserBox.SelectedItem).name + "\nEmail: " + ((User)UserBox.SelectedItem).email;
                    
                    
                }
                else if (UserBox.SelectedIndex < 0)
                {
                    UserInfo.Content = " ";
                }
                    NameBox.Text = userName.name;
                    MailBox.Text = userMail.email;

            }
        }

        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            if (UserBox.SelectedIndex >= 0 && list1Active)
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
            if (AdminBox.SelectedIndex >= 0 && list2Active)
            {
                int position = AdminBox.SelectedIndex;
                AdminBox.Items.RemoveAt(position);
                if (AdminBox.Items.Count <= position)
                    AdminBox.SelectedIndex = position - 1;
                else
                    AdminBox.SelectedIndex = position;
                if (AdminBox.Items.Count == 0)
                    RemoveUser.IsEnabled = false;
            }
        }

        private void AddToAdminList_Click(object sender, RoutedEventArgs e)
        {
            if (UserBox.SelectedIndex >= 0)
            {
                int positionUser = UserBox.SelectedIndex;
                AdminBox.Items.Add((User)UserBox.SelectedItem);
                UserBox.Items.RemoveAt(positionUser);
                if (UserBox.Items.Count <= positionUser)
                    UserBox.SelectedIndex = positionUser - 1;
                else
                    UserBox.SelectedIndex = positionUser;
                if (UserBox.Items.Count == 0)
                    AddToAdminList.IsEnabled = false;
            }
        }


        private void ChangeUser_Click_1(object sender, RoutedEventArgs e)
        {
            if (UserBox.SelectedIndex >= 0 && list1Active)
            {
                int index = UserBox.SelectedIndex;
                UserBox.Items.RemoveAt(UserBox.SelectedIndex);
                UserBox.Items.Insert(index, (new User { name = NameBox.Text, email = MailBox.Text }));
                UserInfo.Content = " ";
                //UserBox.SelectedIndex = -1;
                UserBox.Items.Refresh();

                //UserInfo.Content = "Full information about the selected person:\n\nName: " + ((User)UserBox.SelectedItem).name + "\nEmail: " + ((User)UserBox.SelectedItem).email;
            }
            if (AdminBox.SelectedIndex >= 0 && list2Active)
            {
                int index = AdminBox.SelectedIndex;
                AdminBox.Items.RemoveAt(AdminBox.SelectedIndex);
                AdminBox.Items.Insert(index, (new User { name = NameBox.Text, email = MailBox.Text }));
                UserInfo.Content = " ";
                //AdminBox.SelectedIndex = -1;
                AdminBox.Items.Refresh();


                //UserInfo.Content = "Full information about the selected person:\n\nName: " + ((User)AdminBox.SelectedItem).name + "\nEmail: " + ((User)AdminBox.SelectedItem).email;

            }
            
            //else if (UserBox.SelectedIndex < 0 || AdminBox.SelectedIndex < 0)
            //{
            //    UserInfo.Content = "You need to select a user first!";
            //}

        }


        private void AddToUserList_Click(object sender, RoutedEventArgs e)
        {
            if (AdminBox.SelectedIndex >= 0)
            {
                int positionAdmin = AdminBox.SelectedIndex;
                UserBox.Items.Add((User)AdminBox.SelectedItem);
                AdminBox.Items.RemoveAt(positionAdmin);
                if (AdminBox.Items.Count <= positionAdmin)
                    AdminBox.SelectedIndex = positionAdmin - 1;
                else
                    AdminBox.SelectedIndex = positionAdmin;
                if (AdminBox.Items.Count == 0)
                    AddToUserList.IsEnabled = false;
            }
        }
        private bool list1Active;
        private bool list2Active;

        private void AdminBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var userName = ((User)AdminBox.SelectedItem);
            var userMail = ((User)AdminBox.SelectedItem);
            if (AdminBox.SelectedItem != null)
            {
                AddToUserList.IsEnabled = AdminBox.SelectedIndex >= 0;
                RemoveUser.IsEnabled = AdminBox.SelectedIndex >= 0;

                if (AdminBox.SelectedIndex >= 0)
                {
                    UserInfo.Content = "Full information about the selected person:\n\nName: " + ((User)AdminBox.SelectedItem).name + "\nEmail: " + ((User)AdminBox.SelectedItem).email;


                }
                else if (AdminBox.SelectedIndex < 0)
                {
                    UserInfo.Content = " ";
                }
                NameBox.Text = userName.name;
                MailBox.Text = userMail.email;
            }

        }

        private void UserBox_Focus(object sender, RoutedEventArgs e)
        {
            list1Active = true;
            list2Active = false;
        }

        private void AdminBox_Focus(object sender, RoutedEventArgs e)
        {
            list2Active = true;
            list1Active = false;
        }

        private void NameBox_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            NameBox.Text = string.Empty;
        }

        private void MailBox_DoubleClick(object sender, MouseButtonEventArgs e)
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
