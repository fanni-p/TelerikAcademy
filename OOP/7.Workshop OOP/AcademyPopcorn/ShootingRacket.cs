﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket:Racket
    {
        // Task 13

        private bool isPressed = false;

        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public void Shoot()
        {
            this.isPressed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.isPressed)
            {
                this.isPressed = false;

                List<Bullet> bullets = new List<Bullet>();

                Bullet bullet = new Bullet(new MatrixCoords(this.TopLeft.Row - 2, this.TopLeft.Col + this.Width / 2));

                bullets.Add(bullet);

                return bullets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
