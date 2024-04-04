using System.Numerics;
using Raylib_cs;
namespace Assignment_4
{
    

    internal class Player2
    {
        
        Vector2 playerposition2;
         Vector2 velocity;
         Vector2 size;
        public Color color;
        private int screenWidth = 800;
        private int screenHeight = 600;

        //player constructor 
        public Player2()
        {
            playerposition2 = new Vector2(775, 300);
            size = new Vector2(10, 50);
            velocity.Y = 20;
            velocity.X = 0;
            color = Color.Red;

        }

        //movment 
        public void Move()
        {
            //UP
            if ( Raylib.IsKeyDown(KeyboardKey.Up))
            {
                playerposition2.Y -= velocity.Y;
            }

            //DOWN
            if (Raylib.IsKeyDown(KeyboardKey.Down))
            {
                playerposition2.Y += velocity.Y;
            }
        }
        
        //render the paddle 
        public void RenderPlayer2()
        {
            Raylib.DrawRectangleV(playerposition2, size, color);
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
