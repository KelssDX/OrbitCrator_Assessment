

using System.Text.RegularExpressions;

namespace OrbitCrator_Assessment

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadCombo();
            txt_OrbRes.ReadOnly = true;
            txt_VehRes.ReadOnly = true;
        }


        private List<Orbit> OrbList = null;
        private List<Vehicle> VehList = null;
        public void loadCombo()
        {
            cmb_Weather.Items.Add("Sunny");
            cmb_Weather.Items.Add("Windy");
            cmb_Weather.Items.Add("Rainy");

        }

        private void bt_Result_Click(object sender, EventArgs e)
        {
            try
            {//check if the comboBox are not empty first

                txt_OrbRes.Text = "";
                txt_VehRes.Text = "";
                if (cmb_Weather.Items.Count != 0 && cmb_Weather.Text != "")
                {
                    //check the orbit traffic text boxes are not empty 
                 if(txt_Orb1_Traff.Text != "" && txt_Orb2_Traff.Text != "")
                            {

                        if (Regex.IsMatch(txt_Orb1_Traff.Text, @"^([1-9][0-9]{0,1}|100)$") && Regex.IsMatch(txt_Orb2_Traff.Text, @"^([1-9][0-9]{0,1}|100)$"))
                        {



                            //create List of default values for orbit and vehicle
                            orbitList();
                            vehicleList();
                            WeatherCalculations(cmb_Weather.Text, double.Parse(txt_Orb1_Traff.Text), double.Parse(txt_Orb2_Traff.Text));

                        }
                        else
                        {
                            //alert user
                            MessageBox.Show("Please enter valid  Orbit Speed values (1-100) before clicking Get Result");
                        }
                        


                  }
                    else
                    {
                        //alert user
                        MessageBox.Show("Please enter the Orbit Speed values before clicking Get Result");
                    }
                }
                else
                {
                    //alert user
                    MessageBox.Show("Please select a Weather Condition before clicking Get Result");
                }
            }
            catch (Exception ex)
            {
                //error getting result
                MessageBox.Show("Error getting result: " + ex.Message);
            }
        }

        private void orbitList()
        {
            List<Orbit> orb = new List<Orbit>
            {
                new Orbit {orbitName = "Orbit 1", distance = 18, numCrators = 20},
                new Orbit {orbitName = "Orbit 2", distance = 20, numCrators = 10}
            };

            OrbList = orb;
            
        }

        private void vehicleList()
        {
            List<Vehicle> veh = new List<Vehicle>
            {
                new Vehicle {vehicleName = "Bike", speed = 10, timePerCrator = 2},
                new Vehicle {vehicleName = "Tuktuk", speed = 12, timePerCrator = 1},
                 new Vehicle {vehicleName = "Car", speed = 20, timePerCrator = 3}
            };
            VehList = veh;

        }

        private void WeatherCalculations(string weather, double Orbit1Traffic, double Orbit2Traffic)
            {

            double newCratorNum = 0;

            double milesHourOrb = 0;
            double cratorHour = 0;
            string orbName = "";
            double shortestTime = 0;
            double tempTIme = 0;
            string vehName = "";
            string concatOrb = "";
            string concatVeh = "";
            bool checkHasEqual = false;
            bool firstTime = true;






                // double milesHourOrb2 = 0;

            foreach (var i in OrbList)
                {



                    foreach (var x in VehList)
                    {



                        if ((weather == "Rainy" && (x.vehicleName == "Car" | x.vehicleName == "Tuktuk")) || (weather == "Sunny" | weather == "Windy"))
                        {


                            if (i.orbitName == "Orbit 1" && x.speed >= Orbit1Traffic)
                            {


                                milesHourOrb = Orbit1Traffic;
                            }


                            else if (i.orbitName == "Orbit 2" && x.speed >= Orbit2Traffic)
                            {


                                milesHourOrb = Orbit2Traffic;
                            }
                            else
                            {
                                milesHourOrb = x.speed;
                            }

                            if (weather == "Sunny")
                            {

                                //crators reduced by 10%
                                newCratorNum = i.numCrators - (i.numCrators * (10 / 100));

                            }
                            else if (weather == "Rainy")
                            {
                                //crators increase by 20%
                                newCratorNum = i.numCrators + (i.numCrators * (20 / 100));

                            }
                            else
                            {//default value when windy
                                newCratorNum = i.numCrators;

                            }
                            //get time in hours for time it takes to go through crators
                            cratorHour = (x.timePerCrator * newCratorNum) / 60;

                            shortestTime = (i.distance / milesHourOrb) + cratorHour;

                            //getting the shortest a vehicle would go through an orbit
                            if (tempTIme == 0)
                            {
                                orbName = i.orbitName;
                                tempTIme = shortestTime;
                                vehName = x.vehicleName;
                            checkHasEqual = false;
                            firstTime = true;
                        }
                            else if (tempTIme > shortestTime)
                            {
                                orbName = i.orbitName;
                                tempTIme = shortestTime;
                                vehName = x.vehicleName;
                            checkHasEqual = false;
                            firstTime = true;

                        }
                        else
                        {
                            if (tempTIme == shortestTime)
                            {
                                
                                

                                checkHasEqual = true;

                                if (firstTime == true)
                                {
                                    concatOrb = orbName + " | " +i.orbitName;
                                    concatVeh = vehName + " | " + x.vehicleName;
                                    firstTime = false;
                                }

                                else
                                        {
                                    concatOrb += " | " + i.orbitName;
                                    concatVeh += " | " + x.vehicleName;
                                }
                            }

                        }
                           
                        }
                    }
                
            }
            //result
            if (checkHasEqual != true)
            {


                txt_OrbRes.Text = orbName;
                txt_VehRes.Text = vehName;

            }
            else
            {
                                   
                txt_OrbRes.Text = concatOrb;
                txt_VehRes.Text = concatVeh;
            }

        }

        private void txt_Orb1_Traff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Orb2_Traff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}