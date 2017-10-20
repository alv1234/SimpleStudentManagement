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

namespace SimpleStudentManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        private List<Student> Students = new List<Student>();
        private List<string> studiengaenge = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpeichernBtnClicked(object sender, RoutedEventArgs e)
        {
            Students.Add(new Student(
                tboVorname.Text,
                tboNachname.Text,
                int.Parse(tboAlter.Text),
                cboStudien.SelectedItem.ToString(),
                chkBeitrag.IsChecked.GetValueOrDefault()
                ));
            dtgListe.ItemsSource = null;
            dtgListe.ItemsSource = Students;
        }

        private void MasterClickBtnClick(object sender, RoutedEventArgs e)
        {
            studiengaenge.Add(tboStudium.Text);
            cboStudien.ItemsSource = null;
            cboStudien.ItemsSource = studiengaenge;
            lboDaten.ItemsSource = null;
            lboDaten.ItemsSource = studiengaenge;
        }

        private void EditBtnClick(object sender, RoutedEventArgs e)
        {         
            var temp = dtgListe.SelectedItem as Student;
            tboVorname.Text = temp.vorname;
            tboNachname.Text = temp.nachname;
            tboStudium.Text = temp.studiengang;
            tboAlter.Text = temp.alter.ToString();
            chkBeitrag.IsChecked = temp.beitragBezahlt;
            
        }

        private void LoeschenBtnClick(object sender, RoutedEventArgs e)
        {
            Students.RemoveAt(dtgListe.SelectedIndex);
            dtgListe.ItemsSource = null;
            dtgListe.ItemsSource = Students;
        }
    }
}
