using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fouth : Moving
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (ThirdObject.IsMove)
        //{
        //    Move();
        //}
    }

    public new void Move()
    {
        StartCoroutine(RotateTowardsTarget());
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);

        //if (MovinPointTarget.Lap < 20 && MovinPointTarget.Lap >= 15)
        //{
        //    StartCoroutine(RotateTowardsTarget());
        //    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
        //}
    }
}
