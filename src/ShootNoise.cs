/*
    ShotNoise from www.freesound.org
    File download url: https://www.freesound.org/people/Cyberkineticfilms/sounds/127845/

    File under creative commons license
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Diagnostics;


namespace ScreenShoot {
    class ShootNoise {
        #region Constructor & Destructor

        public ShootNoise() {
            playBulletSound();
        }

        ~ShootNoise() {
            Debug.Print("Deconstructor Noise");
        }

        #endregion

        #region Methods

        private void playBulletSound() {
            // Need to add sound file
            SoundPlayer bulletSound = new SoundPlayer(Properties.Resources.shot_noise);
            bulletSound.Play();
        }

        #endregion
    }
}
