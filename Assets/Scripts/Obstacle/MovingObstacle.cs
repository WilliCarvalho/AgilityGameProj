using System;
using UnityEngine;

public class MovingObstacle : Obstacle
{
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;
    [SerializeField] private float velocity;
    [SerializeField] private int waitTime;
    private float elapsedTime;
    private bool canMove;
    private bool canSwitch;

    private void Awake()
    {
        canMove = true;
        canSwitch = false;
    }

    private void FixedUpdate()
    {
        if (canMove == false)
        {
            TimeCount();
            return;
        }

        if (canSwitch == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                                                     position2.position, 
                                                     velocity * Time.deltaTime);
        }
        else if (canSwitch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                                                     position1.position,
                                                     velocity * Time.deltaTime);
        }

        if(transform.position == position1.position)
        {
            canMove = false;
            canSwitch = false;
        }
        else if(transform.position == position2.position)
        {
            canMove = false;
            canSwitch = true;
        }
    }

    private void TimeCount()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= waitTime)
        {
            canMove = true;
            elapsedTime = 0;
        }
    }
}
