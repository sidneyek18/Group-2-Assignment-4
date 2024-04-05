using System.Numerics;

public class Collision
{
    public Collision()
    {
    }
    //edited by jayce for ball collision with screen
    public void BallCollision(Vector2 playerPosition, Vector2 playerSize, Vector2 ballPosition, Vector2 ballSize)
    {
        // Setting edges for player
        float leftEdge1 = playerPosition.X;
        float rightEdge1 = playerPosition.X + playerSize.X;

        // Setting edges for ball
        float leftEdge2 = ballPosition.X;
        float rightEdge2 = ballPosition.X + ballSize.X;

        // Checking for overlap
        bool doesOverlapLeft = leftEdge1 < rightEdge2;
        bool doesOverlapRight = rightEdge1 > leftEdge2;

        bool doesOverlap = doesOverlapLeft && doesOverlapRight;

        // Perform collision response based on overlap
        if (doesOverlap)
        {
            // Collision occurred, handle it here
            // You can add your collision response logic within this block
        }
    }
}
