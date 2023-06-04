using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Threading;

namespace praktika.pages
{
    /// <summary>
    /// Логика взаимодействия для Authorisation.xaml
    /// </summary>
    public partial class Authorisation : Page
    {
        Model1 context;
        public Authorisation(Model1 cont)
        {
            InitializeComponent();
            context = cont;
            Remind.Visibility = Visibility.Hidden;
        }
        
        int countClick = 0;
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            
            countClick++;
            string log = loginBox.Text;
            string pass = passwordBox.Password;
            Author author = context.Author.ToList().Find(x=> x.login.Equals(log));
            
            if (author != null) 
            {
                
                if(author.password.Equals(pass))
                {
                    context.SaveChanges();
                    NavigationService.Navigate(new MainPage(context));
                    countClick = 0;
                }
                else {
                    MessageBox.Show("Вы ввели неверный пароль ");
                    if (countClick >= 3) {
                        Remind.Visibility= Visibility.Visible;
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует ");
            }
        }

        private void Remind_Click(object sender, RoutedEventArgs e)
        {
            PasRemind pasRemindWindow = new PasRemind(context);
            pasRemindWindow.Show();
        }
    }
}
