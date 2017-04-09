/*
    ShotImage from www.pngimage.com
    Image download url: http://pngimg.com/img/weapons/bullet_hole
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace ScreenShoot {
    class ShootImage {

        private Size shootSize;

        #region Constructor & Destructor

        public ShootImage() {
        }

        ~ShootImage() {
            Debug.Print("Deconstructor Image");
        }

        #endregion

        #region Method

        public Image createImage() {
            Image image = Properties.Resources.bullet_hole2;
            image = (Image)(new Bitmap(image, 100, 100));
            shootSize = new Size(image.Width, image.Height);

            return image;
        }

        public Point getMiddlePoint(Point pos) {
            //Debug.Print(string.Format("image size half: {0} {1}", shootSize.Width / 2, shootSize.Height));
            //Debug.Print(string.Format("point m {0} {1}", middle.X, middle.Y));
            return new Point(pos.X - (shootSize.Width / 2), pos.Y - (shootSize.Height / 2));
        }

        #endregion
    }
}
