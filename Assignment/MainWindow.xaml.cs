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

namespace Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> allActivities = new List<Activity>();
        List<Activity> chosenActivities = new List<Activity>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activites
            Activity a1 = new Activity() { Name = "Surfing", Cost = 50, Description = "Fun in the waves", Date = new DateTime(2019, 12, 25) };
            Activity a2 = new Activity() { Name = "Kayaking", Cost = 50, Description = "More Fun in the waves", Date = new DateTime(2019, 12, 30) };


            allActivities.Add(a1);
            allActivities.Add(a2);

            //display in the listbox
            lstbx.ItemsSource = allActivities;
            lstbx2.ItemsSource = chosenActivities;

            
        }




        #region extramethods
        private void Rbtn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rbtn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rbtn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rbtn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Lstbx_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Lbl1_Loaded(object sender, RoutedEventArgs e)
        {

        }



       

        private void Lstbx2_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Lbl2_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Lbl3_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Lbl4_Loaded(object sender, RoutedEventArgs e)
        {

        }

        #endregion extramethods

        private void Lstbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            Activity selected = lstbx.SelectedItem as Activity;

            if (selected != null)
            {

                //display description
                tblkDescription.Text = selected.Description; //get the description from the object and put it on the screen in the text block


            }
        }


        //Add activity
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //determine what was selected
            Activity selected = lstbx.SelectedItem as Activity;

            //if not null
            if (selected != null)
            {
                //move to other list
                allActivities.Remove(selected);
                chosenActivities.Add(selected);


                //update display
                lstbx.ItemsSource = null;
                lstbx2.ItemsSource = null;

                lstbx.ItemsSource = allActivities;
                lstbx2.ItemsSource = chosenActivities;

            }

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            // determine what was selected
            Activity selected = lstbx2.SelectedItem as Activity;

            // if not null
            if(selected != null)
            {
                // move back to the other list
                allActivities.Remove(selected);
                chosenActivities.Add(selected);

                // update display
                lstbx2.ItemsSource = null;
                lstbx.ItemsSource = null;

                lstbx2.ItemsSource = allActivities;
                lstbx.ItemsSource = chosenActivities;
            }
        }
    }
}
