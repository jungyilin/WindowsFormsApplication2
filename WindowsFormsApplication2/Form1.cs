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

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Button[] btn = new System.Windows.Forms.Button[81];
            Point x=new Point(57,90);
           
            for (int i = 0; i < 81; i++)
            {
                btn[i] = new Button();
                this.Controls.Add(btn[i]);
                btn[i].Text = "";
                btn[i].Top = 20 + (i/9)*20;
                btn[i].Left = (i%9)*20;
                btn[i].Size = new Size(20, 20);
            }
            

        }
    }
}
