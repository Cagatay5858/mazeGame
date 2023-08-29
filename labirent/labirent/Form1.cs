using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirent
{
    public partial class Form1 : Form
    {
        //System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"C : Windows\Media\chord.wav");
        //System.Media.SoundPlayer finishSound = new System.Media.SoundPlayer(@"C : Windows\Media\tada.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }


        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            //finishSound.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void MoveToStart()
        {
            //startSound.Play();
            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
