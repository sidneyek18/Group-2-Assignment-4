using System;
using Raylib_cs;

namespace ballA
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the game");

            int screenWidth = 800;
            int screenHeight = 600;
            Raylib.InitWindow(screenWidth, screenHeight, "ballmovementAmelia");
            Raylib.SetTargetFPS(60);

            int x = screenWidth / 2; // Initial x position
            int y = screenHeight / 2; // Initial y position
            int radius = 20; // Circle radius
            int speed_x = 5; // Horizontal speed
            int speed_y = 5; // Vertical speed

            while (!Raylib.WindowShouldClose())
            {
                // Update ball position based on speed
                x += speed_x;
                y += speed_y;

                // Check for collisions with window edges
                if (y + radius >= screenHeight || y - radius <= 0)
                {
                    speed_y *= -1; // Reverse vertical speed on collision
                }
                if (x + radius >= screenWidth || x - radius <= 0)
                {
                    speed_x *= -1; // Reverse horizontal speed on collision
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                // Drawing
                Raylib.DrawCircle(x, y, radius, Color.White);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
