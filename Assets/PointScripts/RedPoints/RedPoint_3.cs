using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint_3 : RedPoint_23
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(15, RedCar));

            MovingPointTarget.Speed = 15;
            MovingPointTarget.MaxSpeed = 20;
        }
    }
}
