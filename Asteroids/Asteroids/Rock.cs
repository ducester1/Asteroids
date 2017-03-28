using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Rock : SpriteGameObject
    {
        protected SpriteSheet rock1, rock2, rock3;
        public int rockType;
        public Rock()
            :base("")
        {
            rock1 = new SpriteSheet("spr_rock1");
            rock2 = new SpriteSheet("spr_rock2");
            rock3 = new SpriteSheet("spr_rock3");

            rockType  = GameEnvironment.Random.Next(0, 3);
            

            velocity = new Vector2 (GameEnvironment.Random.Next(-50, 50),GameEnvironment.Random.Next(-50,50));
            position = new Vector2(GameEnvironment.Random.Next(0, Asteroids.Screen.X), GameEnvironment.Random.Next(0, Asteroids.Screen.Y));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (rockType < 0) Visible = false;
            else if (rockType == 0) sprite = rock1;
            else if (rockType == 1) sprite = rock2;
            else sprite = rock3;
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
