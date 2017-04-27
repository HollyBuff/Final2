using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2
{
    public partial class Form1 : Form
    {
        Image frame = Final2.Properties.Resources.frame;
        Rectangle frameForm = new Rectangle(0, 0, 424, 393);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(frame, frameForm);
            g.Dispose();
        }

        /* If we click the new game button the game will start*/
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
