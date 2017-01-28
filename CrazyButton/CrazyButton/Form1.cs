using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Point coordinates = Cursor.Position;
            Random r = new Random();
            int bx, by;
            
                bx = r.Next(0, 200);
                by = r.Next(0, 250);
                button1.Location = new Point(bx, by);
            
        }
    }
}
