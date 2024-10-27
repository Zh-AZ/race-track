using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdObject : Moving
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public new void Move()
    {

        if (MovinPointTarget.Lap < 15 && MovinPointTarget.Lap >= 10)
        {
            StartCoroutine(RotateTowardsTarget());
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
        }
    }
}
