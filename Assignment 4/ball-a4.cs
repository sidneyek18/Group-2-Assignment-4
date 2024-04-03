using Raylib_cs;
using System;

namespace ass4_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the game");

            int screenWidth = 800;
            int screenHeight = 600;
            Raylib.InitWindow(screenWidth, screenHeight, "Pong");
            Raylib.SetTargetFPS(60);

            int x = screenWidth / 2; // Y position
            int y = screenHeight / 2; // Y position
            int radius = 20; // circle radius 
            int speed_x = 5; // horizontal speed
            int speed_y = 5; // vertical speed

            while (!Raylib.WindowShouldClose())
            {
                x += speed_x;
                y += speed_y;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                // Drawing
                Raylib.DrawCircle(screenWidth / 2, screenHeight / 2, 20, Color.White);

                Raylib.DrawCircle(screenWidth / 2, screenHeight / 2, 20, Color.White);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}