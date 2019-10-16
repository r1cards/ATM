using CashMachine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class newPinConf : Form
    {

        public newPinConf()
        {
            InitializeComponent();
        }

        private void newPinConf_Load(object sender, EventArgs e)
        {
            label2.Text = (string)Settings.Default["pin"];
            label2.Update();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;




            // ANIMATINO
            Timer tm = new Timer();
            pictureBox1.Image = Properties.Resources.frame11;
            tm.Interval = 25;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            int time = 15;



            //IMPORTANTE ANIMATINO
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.frame11);
            b1.Add(Properties.Resources.frame12);
            b1.Add(Properties.Resources.frame13);
            b1.Add(Properties.Resources.frame14);
            int index = DateTime.Now.Second % b1.Count;
            pictureBox1.Image = b1[index];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            int time = 15;
            label1.Text = time.ToString();
            time--;
            
            if (time == 0)
            {
                MainMenu men = new MainMenu();
                men.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu men = new MainMenu();
            men.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
       

       
    }



