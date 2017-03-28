using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    class Score : TextGameObject
    {
        public int score = 0;
        public Score()
            :base("GameFont")
        {

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            text = "score:" + score;
        }
    }
}
