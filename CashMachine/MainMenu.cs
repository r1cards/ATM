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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Timer tm = new Timer();
            tm.Interval = 25;

            button4.Image = Properties.Resources.ex1;
            
            tm.Tick += new EventHandler(changeImage);
            tm.Start();

            button2.Image = Properties.Resources.mex1;
            
            tm.Tick += new EventHandler(changeImage1);
            tm.Start();

            button3.Image = Properties.Resources.pinnn1;
            
            tm.Tick += new EventHandler(changeImage2);
            tm.Start();



            //IMPORTANTE ANIMATINO
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.ex1);
            b1.Add(Properties.Resources.ex2);
            b1.Add(Properties.Resources.ex3);
            b1.Add(Properties.Resources.ex5);
            b1.Add(Properties.Resources.ex6);



            int index = DateTime.Now.Second % b1.Count;
            button4.Image = b1[index];
        }
        private void changeImage1(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.mex1);
            b1.Add(Properties.Resources.mex2);
            b1.Add(Properties.Resources.mex3);
            b1.Add(Properties.Resources.mex5);
            b1.Add(Properties.Resources.mex5);



            int index = DateTime.Now.Second % b1.Count;
            button2.Image = b1[index];
        }
        private void changeImage2(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.pinnn1);
            b1.Add(Properties.Resources.pinnn2);
            b1.Add(Properties.Resources.pinnn3);
            b1.Add(Properties.Resources.pinnn4);
            b1.Add(Properties.Resources.pinnn5);
            b1.Add(Properties.Resources.pinnn6);
            b1.Add(Properties.Resources.pinnn7);
            b1.Add(Properties.Resources.pinnn8);
            b1.Add(Properties.Resources.pinnn9);
            b1.Add(Properties.Resources.pinnn9);



            int index = DateTime.Now.Second % b1.Count;
            button3.Image = b1[index];
        }


        // View Balance
        private void button1_Click(object sender, EventArgs e)
        {

            CurrencyShowerSelect cur = new CurrencyShowerSelect();
            cur.Show();

           
            this.Close();
        }
        // Withdraw money
        private void button2_Click(object sender, EventArgs e)
        {
            ChoseCurrency chosec = new ChoseCurrency();
            chosec.Show();
            this.Close();

        }
        // Eject Button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Pin Reset button
        private void button3_Click(object sender, EventArgs e)
        {
            PinReset pinr = new PinReset();
            pinr.Show();
            this.Close();
        }
        // opens mini statement
        private void button5_Click(object sender, EventArgs e)
        {
            MiniStatement statement = new MiniStatement();
            statement.Show();
            this.Close();
        }
    }
}
