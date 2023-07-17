using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class formCarRace : Form
    {
        int[] initial_Car1_Coord = { 12, 50 };
        int[] initial_Car2_Coord = { 12, 210 };
        int[] car1_Speed = { 5, 20 };
        int[] car2_Speed = { 5, 20 };
        int car1_Location = 0;
        int car2_Location = 0;
        double time = 0;
        public formCarRace()
        {
            InitializeComponent();
        }

       private static int Acceleration()
        {
            Random Car_accel = new Random();
            int speed = 0;
            int index = 0;

            if(index < 5)
            {
                speed+=Car_accel.Next(index, index + 5);
                index++;
            }
            return speed;
        }
        private void formCarRace_Load(object sender, EventArgs e)
        {

        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            ChangeTimer();
        }

        private void ChangeTimer()
        {
            TimeSpan OutTime = new TimeSpan(0,0,0);

            if (tmr_Car1.Enabled == true && tmr_Car2.Enabled==true)
            {
                tmr_Car1.Enabled = false;
                tmr_Car2.Enabled = false;
                tmr_Car1.Stop();
                tmr_Car2.Stop();

                btn_Start.Text = "Start";

            }
            else
            {
                tmr_Car1.Enabled = true;
                tmr_Car2.Enabled = true;

                lbl_TimePassed.Text = time.ToString();

                btn_Start.Text = "Stop";

            }
        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            tmr_Car1.Equals(0);
            tmr_Car2.Equals(0);

            pb_Car1.Location = new Point(initial_Car1_Coord[0],initial_Car1_Coord[1]);
            pb_Car2.Location = new Point(initial_Car2_Coord[0], initial_Car2_Coord[1]);
            car1_Location = car2_Location = initial_Car1_Coord[0];
            car1_Speed[0] = car2_Speed[0] = 5;
            car1_Speed[1]=car2_Speed[1] = 20;
            
            tmr_Car1.Enabled= false;
            tmr_Car2.Enabled= false;
            btn_Start.Text = "Start";
            lbl_TimePassed.Text = "0.0";
            time = 0;
         

            MessageBox.Show("Positions And Speed have been reset");
            btn_Start.Show();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            tmr_Car1.Enabled=false;
            tmr_Car2.Enabled=false;
            MessageBox.Show("Program will terminate");
            Application.Exit();
        }
        private void tmr_Car1_Tick(object Sender, EventArgs e) //Timer Event for Car1 
        {
            Random r = new Random();
            int speed1;

            speed1 = r.Next(car1_Speed[0],car1_Speed[1]);
            car1_Location += speed1;

            if (car1_Location <= 775 )
            {
                pb_Car1.Location = new Point(car1_Location, initial_Car1_Coord[1]);
                time += .1;
                lbl_TimePassed.Text = time.ToString("F1");
            }
            else
            {
                tmr_Car1.Stop();
                tmr_Car2.Stop();
                MessageBox.Show("Car 1 Won!");
                RaceWinner("Car 1");
                btn_Start.Hide();
            }
        }

        private void tmr_Car2_Tick(object Sender, EventArgs e) //Timer Event for Car2 
        {
            Random r = new Random();
            int speed2;

            speed2 = r.Next(car2_Speed[0], car2_Speed[1]);
            car2_Location += speed2;

            if (car2_Location <= 775)
            {
                pb_Car2.Location = new Point(car2_Location, initial_Car2_Coord[1]);
                time+=.1;
            }
            else
            {
                tmr_Car2.Stop();
                tmr_Car1.Stop();
                MessageBox.Show("Car 2 Won!");
                RaceWinner("Car 2");
                btn_Start.Hide();
            }
        }

        private void RaceWinner(string Win)
        {
            if(Win=="Car 1")
            {
                RaceHistory.Rows.Add(Win,"Car 2", time.ToString("F1"));
            }
            else
            {
                RaceHistory.Rows.Add(Win, "Car 1", time.ToString("F1"));
            }
        }

        private void btnC1_Increase_Click(object sender, EventArgs e)
        {
            if(car1_Speed[1] < 30)
            {
                car1_Speed[0]+=1;
                car1_Speed[1] += 1;
            }
            else
            {
                MessageBox.Show("Car 1 speed has maxed out!");
            }
        }

        private void btnC2_Increase_Click(object sender, EventArgs e)
        {
            if (car2_Speed[1] < 30)
            {
                car2_Speed[0] += 1;
                car2_Speed[1] += 1;
            }
            else
            {
                MessageBox.Show("Car 2 speed has maxed out!");
            }
        }

        private void btnC1_Decrease_Click(object sender, EventArgs e)
        {
            if (car1_Speed[1] >= 0)
            {
                car1_Speed[0] -= 1;
                car1_Speed[1] -= 1;
            }
            else
            {
                MessageBox.Show("Car 1 speed cannot go lower!");
            }
        }

        private void btnC2_Decrease_Click(object sender, EventArgs e)
        {
            if (car2_Speed[1] >= 0)
            {
                car2_Speed[0] -= 1;
                car2_Speed[1] -= 1;
            }
            else
            {
                MessageBox.Show("Car 1 speed cannot go lower!");
            }
        }
    }
}
