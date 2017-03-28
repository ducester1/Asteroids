using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Bullet : RotatingSpriteGameObject
    {

        public Bullet(Vector2 startPosition, Vector2 startVelocity)
            :base("spr_Bullet")
        {
            origin = Center;
            position = startPosition;
            AngularDirection = startVelocity;
            velocity = AngularDirection * 300; 
        }
    }
}
