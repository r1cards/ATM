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
    public partial class PinReset : Form
    {
        public string userPin;
        public PinReset()
        {
            InitializeComponent();
        }

        private void PinReset_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userPin = (string)Settings.Default["pin"];
            if (textBox1.Text.Length == 4)
            {
                newPinConf conff = new newPinConf();
                Settings.Default["pin"] = textBox1.Text;
                Settings.Default.Save();                            
                conff.Show();              
                this.Close();
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    }

