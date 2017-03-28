using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    class Score : TextGameObject
    {
        private int amount;
        public Score()
            :base("GameFont")
        {
            text = amount.ToString();
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                text = amount.ToString();
            }
        }

    }
}
