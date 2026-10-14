using System;

namespace MohawkGame2D
{
    public class Game
    {
        // Starting position of the smiley.
        float smileX = 100;

        public void Setup()
        {
            // Set the game window size.
            Window.SetSize(400, 400);
        }

        public void Update()
        {
            // Move smiley left.
            if (Input.IsKeyboardKeyDown(KeyboardKey.Left) && smileX > 30)
            {
                smileX = smileX - 2;
            }

            // Move smiley right.
            if (Input.IsKeyboardKeyDown(KeyboardKey.Right) && smileX < 370)
            {
                smileX = smileX + 2;
            }

            // Draw flowers.
            Draw.FillColor = Color.Yellow;

            Draw.Circle(50, 340, 10);
            Draw.Circle(125, 340, 10);
            Draw.Circle(200, 340, 10);
            Draw.Circle(275, 340, 10);
            Draw.Circle(350, 340, 10);

            // Draw flower centres.
            Draw.FillColor = Color.Orange;

            Draw.Circle(50, 340, 4);
            Draw.Circle(125, 340, 4);
            Draw.Circle(200, 340, 4);
            Draw.Circle(275, 340, 4);
            Draw.Circle(350, 340, 4);

            // Draw smiley face.
            Draw.FillColor = Color.Yellow;
            Draw.Circle(smileX, 270, 30);

            // Draw eyes.
            Draw.FillColor = Color.Black;

            Draw.Circle(smileX - 10, 260, 3);
            Draw.Circle(smileX + 10, 260, 3);

            // Draw smile.
            Draw.LineColor = Color.Black;

            Draw.Line(smileX - 12, 280, smileX, 286);
            Draw.Line(smileX, 286, smileX + 12, 280);
        }
    }
}