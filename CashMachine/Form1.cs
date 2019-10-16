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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertCardScreen_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Timer tm = new Timer();
            InsertCardImage.Image = Properties.Resources.f1;
            tm.Interval = 25;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            



            //IMPORTANTE ANIMATINO
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.f1);
            b1.Add(Properties.Resources.f2);
            b1.Add(Properties.Resources.f3);
            b1.Add(Properties.Resources.f4);
            b1.Add(Properties.Resources.f5);
            b1.Add(Properties.Resources.f6);
            b1.Add(Properties.Resources.f7);
            b1.Add(Properties.Resources.f8);
            int index = DateTime.Now.Second % b1.Count;
            InsertCardImage.Image = b1[index];
        }
    

        private void InsertCardButton_Click(object sender, EventArgs e)
        {

            CultureCheck cul = new CultureCheck();
            cul.Show();
            



        }
    }
}
