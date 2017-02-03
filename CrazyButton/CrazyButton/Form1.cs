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
            label1.Location = new Point((ClientSize.Width)/2- label1.Text.Length, 20);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Point coordinates = Cursor.Position;
            Random r = new Random();
            int bx, by;
            
                bx = r.Next(button1.Width, ClientSize.Width-button1.Width);
                by = r.Next(button1.Height,ClientSize.Height-button1.Height);
                button1.Location = new Point(bx, by);
            label1.Location = new Point((ClientSize.Width - label1.Text.Length) / 2, 20);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
