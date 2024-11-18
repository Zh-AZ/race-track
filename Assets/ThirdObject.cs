using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdObject : Moving
{
    public bool IsMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        AddRandomSpeed();

        //if (SecondObject.IsMove)
        //{
        //    Move();
        //}

        //if (Speed == 0)
        //{
        //    IsMove = true;
        //}
    }

    //public new void Move()
    //{
    //    StartCoroutine(RotateTowardsTarget());
    //    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);


    //    //if (MovinPointTarget.Lap < 15 && MovinPointTarget.Lap >= 10)
    //    //{
    //    //    StartCoroutine(RotateTowardsTarget());
    //    //    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
    //    //}
    //}
}
