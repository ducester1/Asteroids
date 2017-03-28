using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip spaceShip;
        GameObjectList bullets;

        public PlayingState()
        {
            SpriteGameObject background = new SpriteGameObject("spr_background");
            spaceShip = new SpaceShip();
            bullets = new GameObjectList();

            this.Add(background);
            this.Add(spaceShip);
            this.Add(bullets);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            spaceShip.WrapScreen();
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullets.Add(new Bullet(spaceShip.Position,spaceShip.AngularDirection));
            }
        }

    }
}
