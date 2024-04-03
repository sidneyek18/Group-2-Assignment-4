﻿using Raylib_cs;
using Assignment_4;
namespace Assignment_4
{
    internal class Program
    {
        static string title = "PONG";
        static Player1 p1;
        static void Main(string[] args)
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(800, 600, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(60);

            // Setup your game. This is a function YOU define.
            Setup();

            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {

                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.Black);
                //Draw a white line in the middle
                Raylib.DrawLine(0, 300, 800, 300, Color.White);
                // Your game code here. This is a function YOU define.
                Update();

                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();

            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            
            p1 = new Player1();
            
        }
        static void Update()
        {
           
            p1.Move();
            p1.CheckPlayerWallCollision();
            p1.RenderPlayer();


        }

    }

}
