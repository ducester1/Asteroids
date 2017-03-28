using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class SpaceShip : RotatingSpriteGameObject
    {
        public SpaceShip()
            :base("spr_spaceship")
        {
            origin = Center;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.Up)) velocity += (AngularDirection * 5);
            if (inputHelper.IsKeyDown(Keys.Down)) velocity -= (AngularDirection * 5);
            if (inputHelper.IsKeyDown(Keys.Left)) Degrees += 4;
            if (inputHelper.IsKeyDown(Keys.Right)) Degrees -= 4;
        }

        public void WrapScreen()
        {
            if (position.X > Asteroids.Screen.X) position.X = 0;
            if (position.X < 0) position.X = Asteroids.Screen.X;
            if (position.Y > Asteroids.Screen.Y) position.Y = 0;
            if (position.Y < 0) position.Y = Asteroids.Screen.Y;
        }
    }
}
