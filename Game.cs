// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        // Starting horizontal position of the smiley.
        float smileX = 100;

        public void Setup()
        {
            Window.SetSize(400, 4000);

        }

        public void Update()
        {
            // Move the smiley left but stop it at the edge.
            if (Input.IsKeyboardKeyDown(KeyboardKey.Left) && smileX > 30)
            {
                smileX = smileX - 2;
            }

            // Move the smiley right but stop it at the edge.
            if (Input.IsKeyboardKeyDown(KeyboardKey.Right) && smileX < 370)
            {
                smileX = smileX + 2;
            }

            // -------------------------
            // FLOWERS
            // -------------------------

            Draw.FillColor = Color.Yellow;

            Draw.Circle(new Vector2(50, 340), 10);
            Draw.Circle(new Vector2(125, 340), 10);
            Draw.Circle(new Vector2(200, 340), 10);
            Draw.Circle(new Vector2(275, 340), 10);
            Draw.Circle(new Vector2(350, 340), 10);

            Draw.FillColor = Color.Yellow;

            Draw.Circle(new Vector2(50, 340), 4);
            Draw.Circle(new Vector2(125, 340), 4);
            Draw.Circle(new Vector2(200, 340), 4);
            Draw.Circle(new Vector2(275, 340), 4);
            Draw.Circle(new Vector2(350, 340), 4);

            // -------------------------
            // SMILEY FACE
            // -------------------------

            // Yellow head.
            Draw.FillColor = Color.Yellow;
            Draw.Circle(new Vector2(smileX, 270), 30);

            // Black eyes.
            Draw.FillColor = Color.Black;
            Draw.Circle(new Vector2(smileX - 10, 260), 3);
            Draw.Circle(new Vector2(smileX + 10, 260), 3);

            // Smile.
            Draw.LineColor = Color.Black;
            Draw.Line(
                new Vector2(smileX - 12, 280),
                new Vector2(smileX, 286)
            );

            Draw.Line(
                new Vector2(smileX, 286),
                new Vector2(smileX + 12, 280)
            );
        }
    }
}