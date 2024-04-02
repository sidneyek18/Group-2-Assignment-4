using System;

public class Collision
{
	public Collision()
	{
        public void BallCollision()
        {
            //setting edge for player 
            float leftEdge1 = playerposition.X;
            float rightEdge1 = playerposition.X + size.X;

            //checking for overlap
            bool doesOverlapLeft = leftEdge1 < rightEdge2;
            bool doesOverlapRight = rightEdge1 > leftEdge2;

            //setting edge for ball 
            //add the ball position and size 
            // in this case we are "changing" the ball to a square to do collisions
            float leftEdge2 = rectanglePosition2.X;
            float rightEdge2 = rectanglePosition2.X + rectangleSize2.X;

            bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
        }
    }
}
