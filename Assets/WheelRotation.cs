using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Moving moving;

    // Update is called once per frame
    void Update()
    {
        if (moving.Speed > 0)
        {
            transform.Rotate(0, 0, 5);
        }
    }
}
