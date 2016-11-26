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
        private string Text
        {
            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";   

        }

        private void Get_number()
        {
            Text = userControl11.Numbers;
        }

        private void userControl11_MouseClick(object sender, MouseEventArgs e)
        {
            Get_number();
        }
        
        private void userControl11_numEvent(object sender, ClassLibrary1.UserControl1.NumArgs e)
        {
            Text = Text + e.n;
        }

        private void userControl11_DeleteEvent()
        {
            Text = "";
        }

        private void userControl11_BackEvent()
        {
            if(Text!="")Text = Text.Remove(Text.Length-1,1);
        }
    }
}
