using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* issues
 * --перебрать 8 клеток вокруг одной
 * 
 * to do
 * --add comments
 * --rewrite that fragment with 8 repeting things (use Exist)
 */

namespace my1stMines
{
    public partial class myNiceForm : Form
    {
        Desk myLovelyDesk;

        Tuple<int, int> deskMode = new Tuple<int, int>(9, 10); //desk state (size, number of mines)
        string colorScheme = "GrayAndOrange"; //color scheme

        Graphics gra; //for drawing
        Bitmap myBitmap;

        public myNiceForm()
        {
            InitializeComponent();
        }

        private void myNiceForm_Load(object sender, EventArgs e)
        {
            ReloadDesk();
        }

        void ReloadDesk() 
        {
            myBitmap = new Bitmap(deskPicBox.Width, deskPicBox.Height);
            gra = Graphics.FromImage(myBitmap);
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            myLovelyDesk = new Desk(deskMode.Item1, deskMode.Item2);
            DrawDeskOnForm();
        }

        void DrawDeskOnForm()
        {
            gra.Clear(Color.Silver); //(is there a better way?)
            myLovelyDesk.DrawMe(gra, deskPicBox.Width, deskPicBox.Height, colorScheme);

            flagLabel.Text = "Flags left: " + myLovelyDesk.FlagsLeft();

            //deskPicBox.Image = null;
            deskPicBox.Image = myBitmap;
        }

        private void myNiceForm_Resize(object sender, EventArgs e)
        {
            myBitmap = new Bitmap(deskPicBox.Width, deskPicBox.Height);
            gra = Graphics.FromImage(myBitmap);
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            DrawDeskOnForm();
            //when w < h it looks bad, need to fix it somehow
        }

        private void deskPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) myLovelyDesk.InterectWithCell(e.X, e.Y, 'l'); //lmb was pressed
            if (e.Button == MouseButtons.Right) myLovelyDesk.InterectWithCell(e.X, e.Y, 'r'); //rmb was pressed
            DrawDeskOnForm();

            switch (myLovelyDesk.CheckWinLose())
            {
                case 1: { MessageBox.Show("Congrats, dude!"); ReloadDesk(); break; } //finish game and start a new one
                case -1: { MessageBox.Show("Oh no!"); ReloadDesk(); break; }
            }

        }

        private void x1010ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deskMode = new Tuple<int, int>(9, 10);
            ReloadDesk();
        }

        private void x1640ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deskMode = new Tuple<int, int>(16, 40);
            ReloadDesk();
        }

        private void darkBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorScheme = "DarkBlue";
            DrawDeskOnForm();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorScheme = "Purple";
            DrawDeskOnForm();
        }

        private void blackAndOrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorScheme = "GrayAndOrange";
            DrawDeskOnForm();
        }
    }
}
