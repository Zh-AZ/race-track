using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint_52 : RedPoint_23
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(20.50f, BlueCar));

            MovingPointTarget.Speed = 20;
            MovingPointTarget.MaxSpeed = 25;
        }
    }
}
