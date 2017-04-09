using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScreenShoot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MessageBox.Show("Exit: Ctrl + E", "Exit Application");
            this.TopMost = true;
        }

        private PictureBox box;

        #region Event

        private void Form1_Load(object sender, EventArgs e) {
            goFullScrenn();
            setTransparentBackground();
            addPBBack();
            //Debug.Print(string.Format("pantalla {0} {1}", Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height));
            //Debug.Print(string.Format("box {0} {1}", box.Width, box.Height));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.E) {
                this.Close();
            }
        }

        private void Form1_Click(object sender, EventArgs e) {
            //shootBullet();
        }

        private void PBox_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point point = me.Location;
            //Debug.Print(string.Format("point p {0} {1}", point.X, point.Y));
            shootBullet(point);
        }

        #endregion

        #region Private Methods

        private void goFullScrenn() {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void setTransparentBackground() {
            this.BackColor = Color.Turquoise;
            this.TransparencyKey = Color.Turquoise;
        }

        private void shootBullet(Point point) {
            drawShoot(point);
            new ShootNoise();
        }

        private void addPBBack() {
            box = new PictureBox() {
                Name = "screen",
                // this.Size coges tambien la barra de herramientas, con working area no la coges
                //Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height),
                Size = this.Size,
                Location = new Point(0, 0),
                BackColor = Color.Turquoise
            };

            box.Click += PBox_Click;

            this.Controls.Add(box);
        }

        private void drawShoot(Point point) {
            Graphics g = box.CreateGraphics();
            ShootImage shoot = new ShootImage();
            g.DrawImage(shoot.createImage(), shoot.getMiddlePoint(point));
        }

        #endregion
    }
}
