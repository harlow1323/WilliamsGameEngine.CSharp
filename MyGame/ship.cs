using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace MyGame
{
        class Ship : GameObject
        {
            private readonly Sprite _sprite = new Sprite();

            public Ship()
            {
                _sprite.Texture = Game.GetTexture("Resources/ship.png");
                _sprite.Position = new Vector2f(100, 100);
            }
            public override void Draw()
            {
                Game.RenderWindow.Draw(_sprite);

            }
            public override void Update(Time elapsed)
            {
                Vector2f pos = _sprite.Position;
            float x = pos.X;
            float y = pos.Y;

            int msElapsed = elapsed.AsMilliseconds();

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
            _sprite.Position = new Vector2f(x, y);

            }
         
        }
    }

