using UnityEngine;

public class RotatingObstacle : Obstacle
{
    [SerializeField] private float rotationVelocity;
    [SerializeField] private bool isRotatingLeft;

    private void Update()
    {
        if (isRotatingLeft)
        {
            transform.Rotate(0, -rotationVelocity * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, rotationVelocity * Time.deltaTime, 0);
        }
    }
}
