using Raylib_cs;
using System;

namespace ass4_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 800;
            const int screenHeight = 600;

            Raylib.InitWindow(screenWidth, screenHeight, "ballmovA");
            Raylib.SetTargetFPS(60);

            int x = screenWidth / 2; // X position
            int y = screenHeight / 2; // Y position
            int radius = 20; // circle radius
            int speed_x = 6; // horizontal speed
            int speed_y = 6; // vertical speed

            while (!Raylib.WindowShouldClose())
            {
                // Update
                x += speed_x;
                y += speed_y;

                // Collision detection with screen edges
                if ((x >= (screenWidth - radius)) || (x <= radius))
                    speed_x *= -1;
                if ((y >= (screenHeight - radius)) || (y <= radius))
                    speed_y *= -1;

                // Draw
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Raylib.DrawCircle(x, y, radius, Color.White);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}








