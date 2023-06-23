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

namespace praktika.pages
{
    /// <summary>
    /// Логика взаимодействия для RepairPage.xaml
    /// </summary>
    public partial class RepairPage : Page
    {
        Model1 context;
        public RepairPage(Model1 cont)
        {
            InitializeComponent();
            context = cont;
            listDevices.ItemsSource = cont.Repair.ToList();
            var statusList = cont.Status.ToList();
            statusList.Insert(0, new Status() { Title = "Все" });
            statusBox.ItemsSource = statusList;
            statusBox.SelectedIndex = 0;

        }
        void FilterData()
        {
            var list = context.Repair.ToList();
            if (statusBox.SelectedIndex != 0)
            {
                Status status = statusBox.SelectedItem as Status;
                list = list.Where(x => x.status == status.id).ToList();
            }
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                list = list.Where(x => x.DeviceTitle.Contains(searchBox.Text)).ToList();
            }

            listDevices.ItemsSource = list;

        }

        private void ChangeStatus(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        private void SearchChange(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }
    }
}
