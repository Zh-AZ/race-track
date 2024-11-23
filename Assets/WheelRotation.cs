using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Moving moving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(RoatateWheel());

        //transform.Rotate(Vector3.forward * Time.deltaTime * 360f);

        if (moving.Speed > 0)
        {
            transform.Rotate(0, 0, 5);
        }
    }

    IEnumerator RoatateWheel()
    {
        if (moving.Speed > 0)
        {
            transform.Rotate(0, 0, 5);
            yield return null;
        }
    }
}
