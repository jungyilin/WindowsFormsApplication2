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
        public int[] bomb;
        public Form1()
        {
            InitializeComponent();
            bomb = new int[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Button[,] btn = new Button[9, 9];
            Point x=new Point(57,90);
       
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0;j < 9;j++)
                {
                    btn[i, j] = new Button();
                    this.Controls.Add(btn[i, j]);
                    btn[i, j].Name = i+j.ToString() ;
                    btn[i, j].Top = 20 * (i+j/9) + 20;
                    btn[i, j].Left = (j%9)*20;
                    btn[i, j].Left = 20*j;
                    btn[i, j].Size = new Size(20,20);
                    btn[i, j].Click += new EventHandler(btn_Click);

                }
            }
            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next() % 9;
                int b = rand.Next() % 9;
                bomb[i] = a*10+b;
                //MessageBox.Show(bomb[i].ToString(),i.ToString());
                
            }
            
            
        }
        public void btn_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            int x = Convert.ToInt32(btn.Name);
            int chk1 = x-11;
            int chk2 = x-10;
            int chk3 = x-9;
            int chk4 = x-1;
            int chk5 = x+1;
            int chk6 = x+9;
            int chk7 = x+10;
            int chk8 = x+11;
            int bc = 0;
            
            for (int i = 0; i < 10; i++)
            {
                if (bomb[i] == Convert.ToInt32(btn.Name)) 
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
                if (x == 11)
                {
                    
                }
                
            }
            

            //x-11 x-10 x-9 x-1 x+1 x+9 x+10 x+11
            //MessageBox.Show(x.ToString());
        }
       
    }
}
