using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paitent_queue_system
{
    public partial class MainWindow : Window
    {
        Queue patientQueue = new Queue();

        int token = 0;
        bool doctorArrived = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        // CREATE TOKEN
        private void createtoken_Click(object sender, RoutedEventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show("Enter Patient Name");
                return;
            }

            token++;

            string patient = "Token No: " + token +
                             "\nPatient Name: " + txtPatientName.Text;

            patientQueue.Enqueue(patient);

            MessageBox.Show("Token Created: " + token);

            txtPatientName.Clear();

            txtQueueCount.Text = "Waiting Patients: " + patientQueue.Count;
        }

        // DOCTOR ARRIVED
        private void doctor_arrived_Click(object sender, RoutedEventArgs e)
        {
            if (doctorArrived == true)
            {
                MessageBox.Show("Doctor Already Arrived");
                return;
            }

            doctorArrived = true;

            MessageBox.Show("Doctor Arrived");

            if (patientQueue.Count > 0)
            {
                txtCurrentPatient.Text = patientQueue.Dequeue().ToString();
            }
            else
            {
                txtCurrentPatient.Text = "No patients waiting";
            }

            txtQueueCount.Text = "Waiting Patients: " + patientQueue.Count;
        }

        // NEXT PATIENT
        private void next_paient_Click(object sender, RoutedEventArgs e)
        {
            if (doctorArrived == false)
            {
                MessageBox.Show("Doctor Not Arrived Yet");
                return;
            }
            else
            {
                txtCurrentPatient.Text = "No patients waiting";
            }

            txtQueueCount.Text = "Waiting Patients: " + patientQueue.Count;
        }
    }
}