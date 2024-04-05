using System;
using Raylib_cs;

namespace ass4_practice
{
    internal class Background
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the game");

            int screenWidth = 800;
            int screenHeight = 600;
            Raylib.InitWindow(screenWidth, screenHeight, "Pong");
            Raylib.SetTargetFPS(60);

            int x = screenWidth / 2; // X position
            int y = screenHeight / 2; // Y position
            int radius = 20; // Circle radius
            int speed_x = 5; // Horizontal speed
            int speed_y = 5; // Vertical speed

            while (!Raylib.WindowShouldClose())
            {
                x += speed_x;
                y += speed_y;

                // Collision detection with screen boundaries
                if (x + radius >= screenWidth || x - radius <= 0)
                {
                    speed_x = -speed_x; // Reverse horizontal direction
                }

                if (y + radius >= screenHeight || y - radius <= 0)
                {
                    speed_y = -speed_y; // Reverse vertical direction
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                // Drawing the circle
                Raylib.DrawCircle(x, y, radius, Color.White);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
