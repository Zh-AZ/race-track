using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint_54 : RedPoint_23
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
            StartCoroutine(ChangeSpeed(30, BlueCar));

            MovingPointTarget.Speed = 30;
            MovingPointTarget.MaxSpeed = 35;
        }
    }
}
