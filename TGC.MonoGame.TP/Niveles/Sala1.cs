﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Elements;

namespace TGC.MonoGame.TP.Niveles
{
    public class Sala1 : Sala
    {
        private SpinningPillar Pilar { get; set; }

        private Coin Coin { get; set; }

        public Sala1(ContentManager content, GraphicsDevice graphicsDevice, Vector3 posicion) : base(content, graphicsDevice, posicion)
        {
            PisoWorld = Matrix.CreateScale(new Vector3(10f, 1f, 10f)) * Matrix.CreateTranslation(new Vector3(-45f, 0, 0) + posicion);

            Pilar = new SpinningPillar(graphicsDevice, posicion);

            Coin = new Coin(graphicsDevice, new Vector3(0, 60f, 0) + posicion);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Coin.Update(gameTime);
            Pilar.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, Matrix view, Matrix projection)
        {
            base.Draw(gameTime,view,projection);
            Pilar.Draw(view, projection);
            Coin.Draw(view, projection);
        }
    }
}
