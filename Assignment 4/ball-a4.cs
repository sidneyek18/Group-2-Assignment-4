using Raylib_cs;

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

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                // Drawing

                Raylib.DrawCircle(screenWidth / 2, screenHeight / 2, 20, Color.White);


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
