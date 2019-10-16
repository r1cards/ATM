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
    public partial class WithdrawConfirmation : Form
    {
        public WithdrawConfirmation()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawConfirmation_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Timer tm = new Timer();
            pictureBox1.Image = Properties.Resources.frame1;
            tm.Interval = 25;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            ChoseAmmount chm = new ChoseAmmount();
            ChoseCurrency cc = new ChoseCurrency();

            chm.parsingNumber = button1.Text;
            textBox1.Text = (string)Settings.Default["currencySign"];
            



        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 =  new List<Bitmap>();
            b1.Add(Properties.Resources.frame3);
            b1.Add(Properties.Resources.frame4);
            b1.Add(Properties.Resources.frame5);
            b1.Add(Properties.Resources.frame6);

            b1.Add(Properties.Resources.frame6);
            int index = DateTime.Now.Second % b1.Count;
            pictureBox1.Image = b1[index];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu men = new MainMenu();
            men.Show();
            this.Close();
        }
    }
}
