using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip spaceShip;
        public PlayingState()
        {
            SpriteGameObject background = new SpriteGameObject("spr_background");
            spaceShip = new SpaceShip();

            this.Add(background);
            this.Add(spaceShip);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            spaceShip.WrapScreen();
        }

    }
}
