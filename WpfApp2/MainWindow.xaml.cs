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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> listStudents = new List<Student>();
        Student selectedStudent;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnShowStudents_Click(object sender, RoutedEventArgs e)
        {
            initializeStudents();
            gridStudents.ItemsSource = listStudents;
        }

        private void initializeStudents()
        {
            listStudents.Add(new Student("Jim", "Smith"));
            listStudents.Add(new Student("Jill", "Smith"));
            listStudents.Add(new Student("Ann", "Jones"));
            listStudents.Add(new Student { Fname = "Lisa", Lname = "Daniels", Address = "Haartring 101" });
        }

        private void gridStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStudent = gridStudents.SelectedItem as Student;
            tbResult.Text = selectedStudent.Fname+" "+selectedStudent.Lname;
            btnInfo.IsEnabled = true;
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo objectStudentinfo = new StudentInfo(selectedStudent.Fname);
            objectStudentinfo.Show();
            //this.Close();
            //objectStudentinfo.ShowDialog();
            
        }
    }
}
