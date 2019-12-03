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
        List<Activity> filteredActivities = new List<Activity>();
        decimal totalCost = 0;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activites
            Activity a1 = new Activity() { Name = "Surfing", Cost = 50, Description = "2 hour surf lesson on the wild atlantic way. Cost = €50", Date = new DateTime(2019, 06, 06) , TypeOfActivity = "Water"};
            Activity a2 = new Activity() { Name = "Kayaking", Cost = 40, Description = "Half day lakeland kayak with island picnic. Cost = €40", Date = new DateTime(2019, 06, 07), TypeOfActivity = "Water" };
            Activity a3 = new Activity() { Name = "Handgliding", Cost = 90, Description = "Soar on hot air currents and enjoy spectacular views of the coastal region. Cost = €90 ", Date = new DateTime(2019, 06, 08), TypeOfActivity = "Air" };
            Activity a4 = new Activity() { Name = "Trecking", Cost = 20, Description = "Instructor led group trek through local mountains. Cost = €20 ", Date = new DateTime(2019, 06, 01), TypeOfActivity = "Land" };
            Activity a5 = new Activity() { Name = "Mountain Biking", Cost = 20, Description = "Instructor led half day mountain biking.  All equipment provided. Cost = €20 ", Date = new DateTime(2019, 06, 02), TypeOfActivity = "Land" };
            Activity a6 = new Activity() { Name = "Abseiling", Cost = 40, Description = "Experience the rush of adrenaline as you descend cliff faces from 10-500m. Cost = €40", Date = new DateTime(2019, 06, 03), TypeOfActivity = "Land" };
            Activity a7 = new Activity() { Name = "Parachuting", Cost = 110, Description = "Experience the thrill of free fall while you tandem jump from an airplane. Cost = €110 ", Date = new DateTime(2019, 06, 04), TypeOfActivity = "Air" };
            Activity a8 = new Activity() { Name = "Helicopter Tour", Cost = 200, Description = "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters. Cost = €200", Date = new DateTime(2019, 06, 05), TypeOfActivity = "Air" };


            allActivities.Add(a1);
            allActivities.Add(a2);
            allActivities.Add(a3);
            allActivities.Add(a4);
            allActivities.Add(a5);
            allActivities.Add(a6);
            allActivities.Add(a7);
            allActivities.Add(a8);

            //display in the listbox
            lstbx.ItemsSource = allActivities;
            lstbx2.ItemsSource = chosenActivities;


        }




        #region extramethods






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

        private void Rbtn1_Click(object sender, RoutedEventArgs e)
        {
            filteredActivities.Clear();
            lstbx.ItemsSource = null;  //clear out what is displayed in listbox

            if (rbtn1.IsChecked == true)
            {
                //MessageBox.Show("1");
                lstbx.ItemsSource = allActivities;
            }
            else if (rbtn2.IsChecked == true)
            {
                //MessageBox.Show("2");

                //DISPLAY LAND ITEMS
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Land")
                        filteredActivities.Add(activity);
                }
                lstbx.ItemsSource = filteredActivities;

            }
            else if (rbtn3.IsChecked == true)
            {
                //MessageBox.Show("");
                //Display Water Items
                foreach(Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Water")
                        filteredActivities.Add(activity);
                }
                lstbx.ItemsSource = filteredActivities;

            }
            else if (rbtn4.IsChecked == true)
            {
                //MessageBox.Show("4");
                //Display Air Items
                foreach(Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Air")
                        filteredActivities.Add(activity);
                }
                lstbx.ItemsSource = filteredActivities;
                
            }
        }





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

                totalCost += selected.Cost;
                TxblkCost.Text = totalCost.ToString();
            }

            //message when no activity is chosen
            else
            {
                MessageBox.Show("An activity was not selected");
            }
            

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            // determine what was selected
            Activity selected = lstbx2.SelectedItem as Activity;

            // if not null
            if (selected != null)
            {
                // move back to the other list
                allActivities.Add(selected);
                chosenActivities.Remove(selected);

                // update display
                lstbx.ItemsSource = null;
                lstbx2.ItemsSource = null;

                lstbx.ItemsSource = allActivities;
                lstbx2.ItemsSource = chosenActivities;
            }
        }

    }
}
