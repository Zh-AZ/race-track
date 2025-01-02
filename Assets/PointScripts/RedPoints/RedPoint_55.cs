using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint_55 : RedPoint_23
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
            StartCoroutine(ChangeSpeed(21, BlueCar));

            MovingPointTarget.Speed = 21;
            MovingPointTarget.MaxSpeed = 26;
        }
    }
}
