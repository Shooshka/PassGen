using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generate());
        }

        public static string generate()
        {
            string high = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string low = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            string password = "";

            Random rnd = new Random();
            password += high[rnd.Next(0, high.Length)];
            for (int i = 1; i < 7; i++)
            {
                password += low[rnd.Next(0, low.Length)];
            }

            password += numbers[rnd.Next(0, numbers.Length)];

            return password;

        }
    }

    
}
