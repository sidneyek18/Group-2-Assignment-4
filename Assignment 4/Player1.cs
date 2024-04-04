using System.Numerics;
using Raylib_cs;
namespace Assignment_4
{
    

    public class Player1
    {
        
        Vector2 playerposition;
         Vector2 velocity;
         Vector2 size;
        public Color color;
        private int screenWidth = 800;
        private int screenHeight = 600;

        //player constructor 
        public  Player1()
        {
            playerposition = new Vector2(25, 300);
            size = new Vector2(10, 50);
            velocity.Y = 10;
            velocity.X = 0;
            color = Color.Blue;

        }

        //movment 
        public void Move()
        {
            //UP
            if ( Raylib.IsKeyDown(KeyboardKey.W))
            {
                playerposition.Y -= velocity.Y;
            }

            //DOWN
            if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                playerposition.Y += velocity.Y;
            }
        }
        
        //render the paddle 
        public void RenderPlayer()
        {
            Raylib.DrawRectangleV(playerposition, size, color);
        }

        //collision with the walls 
        public void CheckPlayerWallCollision()
        {
            if (playerposition.Y < 0)
            {
                playerposition.Y = 0;
            }

            if (playerposition.Y + size.Y > screenHeight)
            {
                playerposition.Y = screenHeight - size.Y;
            }
        }

        public void BallCollision()
        {
            float leftEdge1 = playerposition.X;
            float rightEdge1 = playerposition.X + size.X;
            bool doesOverlapLeft = leftEdge1 < rightEdge1;
            bool doesOverlapRight = rightEdge1 > leftEdge1;


        }
    }
    
}
