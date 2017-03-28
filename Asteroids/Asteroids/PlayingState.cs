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
        GameObjectList bullets, rocks;
        Score score;

        public PlayingState()
        {
            SpriteGameObject background = new SpriteGameObject("spr_background");
            spaceShip = new SpaceShip();
            bullets = new GameObjectList();
            rocks = new GameObjectList();
            score = new Score();

            this.Add(background);
            this.Add(spaceShip);
            this.Add(bullets);
            this.Add(rocks);
            this.Add(score);

            for (int i = 0; i < 20; i++)
            {
                rocks.Add(new Rock());
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            spaceShip.WrapScreen();
            foreach (Rock r in rocks.Objects)
            {
                r.WrapScreen();

                foreach (Bullet b in bullets.Objects)
                {
                    if (b.CollidesWith(r) && b.Visible && r.Visible)
                    {
                        r.rockType--;
                        b.Visible = false;
                        score.score += 10;
                    }
                }
                if (r.CollidesWith(spaceShip)) Asteroids.GameStateManager.SwitchTo("GameOverState");
            }
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
