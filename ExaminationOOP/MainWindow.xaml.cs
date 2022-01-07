using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ExaminationOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ObservableCollection<Member> memberList = new ObservableCollection<Member>();
        List<Member> memberList = new List<Member>();
        public MainWindow()
        {
            InitializeComponent();


        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

            Member m1 = new Member() { Name = "Ella Doyle", Fee = 500, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 500, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 500, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 750, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 750, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 750, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };



            memberList.Add(m1);
            memberList.Add(m2);
            memberList.Add(m3);
            memberList.Add(jm1);
            memberList.Add(jm2);
            memberList.Add(jm3);
            memberList.Add(sm1);
            memberList.Add(sm2);
            memberList.Add(sm3);
            memberListLstbx.ItemsSource = memberList;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
