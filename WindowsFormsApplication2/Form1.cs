using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string textTo
        {
            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            textTo = "";   
        }

        private void Get_number()
        {
            textTo = userControl11.Numbers;
        }

        private void userControl11_MouseClick(object sender, MouseEventArgs e)
        {
            Get_number();
        }
        
        private void userControl11_numEvent(object sender, ClassLibrary1.UserControl1.NumArgs e)
        {
            if (textTo.Length == 3|| textTo.Length == 7 || textTo.Length == 11) { textTo = textTo + '-'; }
            if (textTo.Length < 14)
            {
                textTo = textTo + e.n;
            }
            else { Check(); }
        }

        private void userControl11_DeleteEvent()
        {
            textTo = "";
        }
        private void Check()
        {
            if (textTo.Length == 14)
            {
                string a = textTo.Substring(textTo.Length-2,2);
                string b = textTo.Substring(0, 11);
                int sum = 0;
                int i = 9;
                foreach(char c in b)
                {
                    if (c != ' ')
                    {
                        sum = sum + (Convert.ToInt32(c)* i);
                        i--;
                    }
                }
                if(sum > 99)
                {
                    if (sum != 100 || sum != 101) { sum = sum % 101;  }
                    else { sum = 0; }
                }
                b = sum.ToString();
                if (b.Length<2) {b = ' ' + b; }
                if(a != b) { MessageBox.Show("Wrong pass"); }
            }
        }
        private void userControl11_BackEvent()
        {
            if (textTo != "")
            {
                textTo = textTo.Remove(textTo.Length - 1, 1);
                if (textTo != "" &&textTo[textTo.Length - 1] == '-')
                { textTo = textTo.Remove(textTo.Length - 1, 1); }
            }
        }
    }
}
