﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock:Block
    {
        // Task 10 - Implement an ExplodingBlock
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(-1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, 1)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, -1)));
            }
            return produceObjects;
        }
    }
}
