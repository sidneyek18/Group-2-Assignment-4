using System.Numerics;
using Raylib_cs;
namespace Assignment_4
{
    

    internal class Player2
    {
        
        Vector2 playerposition;
         Vector2 velocity;
         Vector2 size;
        public Color color;
        private int screenWidth = 800;
        private int screenHeight = 600;

        //player constructor 
        public Player2()
        {
            player2position = new Vector2(35, 400);
            size = new Vector2(20, 60);
            velocity.Y = 20;
            velocity.X = 0;
            color = Color.Blue;

        }

        //movment 
        public void Move()
        {
            //UP
            if ( Raylib.IsKeyDown(KeyboardKey.Up))
            {
                playerposition.Y -= velocity.Y;
            }

            //DOWN
            if (Raylib.IsKeyDown(KeyboardKey.Down))
            {
                playerposition.Y += velocity.Y;
            }
        }
        
        //render the paddle 
        public void RenderPlayer2()
        {
            Raylib.DrawRectangleV(player2position, size, color);
        }

        //collision with the walls 
        public void CheckPlayer2WallCollision()
        {
            if (playerposition2.Y < 0)
            {
                playerposition2.Y = 0;
            }

            if (playerposition2.Y + size.Y > screenHeight)
            {
                playerposition2.Y = screenHeight - size.Y;
            }
        }

        public void BallCollision()
        {
            float leftEdge2 = playerposition2.X;
            float rightEdge2 = playerposition2.X + size.X;
            bool doesOverlapLeft = leftEdge2 < rightEdge2;
            bool doesOverlapRight = rightEdge2 > leftEdge2;


        }
    }
    
}
