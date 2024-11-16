using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondObject : Moving
{
    public bool IsMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(RotateTowardsTarget());
        Move();
        AddRandomSpeed();

        //if (MovingCar.Go)
        //{
        //    Move();
        //}

        //if (Speed == 0)
        //{
        //    IsMove = true;
        //}
    }

    public new void Move()
    {
        StartCoroutine(RotateTowardsTarget());
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);

        //if (MovinPointTarget.Lap < 10 && MovinPointTarget.Lap >= 5)
        //{
        //    StartCoroutine(RotateTowardsTarget());
        //    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
        //}
    }
}
