using Avalonia.Controls;
using Avalonia.Input;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace session12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Authorization_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            bool findUser = true;
            foreach (Users user in Info.users)
            {
                if (passwd.Text == user.password && login.Text == user.login)
                {
                    findUser = true;
                    switch (user.role)
                    {
                        case "admin":
                            findUser = true;
                            Info.codeRole = 0;
                            errorMessage.IsVisible = false;
                            break;
                        case "user":

                            Info.codeRole = 1;
                            errorMessage.IsVisible = false;
                            break;

                    }
                }
                /* else 
                 {
                     findUser = false;

                 }*/
            }

            if (Info.codeRole != 1 && Info.codeRole != 0)
            {
                errorMessage.Text = "Ошибка";
                errorMessage.IsVisible = true;
            }
            else
            {
                Catalog catalog = new Catalog();
                catalog.Show();
                this.Close();
            }

        }
        private void Guest_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Info.codeRole = 2;
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Close();

        }

        private void login_OnKeyUp(object? sender, KeyEventArgs e)
        {
            errorMessage.IsVisible=false;
        }
        private void passwd_OnKeyUp(object? sender, KeyEventArgs e)
        {
            errorMessage.IsVisible = false;
        }

    }
}
