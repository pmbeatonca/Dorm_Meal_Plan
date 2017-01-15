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

namespace Dorm_Meal_Plan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;

            //check if there is a selected index

            if (lsRoom.SelectedIndex < 0) 
            {
                MessageBox.Show("You are doing wrong my friend, please select one room");
                
            }
            else if (lsMeals.SelectedIndex<0)
            {
                MessageBox.Show("You are doing wrong my friend, please select one meal plan");
            }
            else
            {    // now calculating the room selection--

                if(lsRoom.SelectedIndex==0)
                {
                    total += 1500;
                }
                else if (lsRoom.SelectedIndex == 1)
                {
                    total += 1600;
                }
                else if (lsRoom.SelectedIndex == 2)
                {
                    total += 1800;
                }
                else if (lsRoom.SelectedIndex == 3)
                {
                    total += 2500;
                }
                // calculating the meals plan total

                if (lsMeals.SelectedIndex == 0)
                {
                    total += 600;
                }
                else if (lsMeals.SelectedIndex == 1)
                {
                    total += 1200;
                }
                else if (lsMeals.SelectedIndex == 2)
                {
                    total += 1700;
                }
                // Create the result value for the second window

                result = new Calculate(total);
                result.ShowDialog();
            }
        }
    }
}
