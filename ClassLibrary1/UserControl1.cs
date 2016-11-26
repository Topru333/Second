using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class UserControl1 : UserControl
    {
        private string numbers = "0";
        public class NumArgs : EventArgs {
            public char n;
        }
        public delegate void NumDel(object sender, NumArgs e);
        public delegate void NumC();
        public event NumDel numEvent;
        public event NumC DeleteEvent;
        public event NumC BackEvent;
        public string Numbers
        {
            set {  }
            get { return this.numbers; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        public void ButtonCollor()
        {
            foreach(Button b in this.Controls)
            {
                 b.BackColor = Color.Black; 
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (numEvent != null)
                numEvent(this, new NumArgs { n = ((Button)sender).Text[0] });
            Null();
            Numbers += ((Button)sender).Text;
        }
        private void Null()
        {
            if (Numbers == "0")
            {
                Numbers = "";
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            DeleteEvent();
        }
        private void Back_Click(object sender, EventArgs e)
        { 
                BackEvent();
        }

    }
}
