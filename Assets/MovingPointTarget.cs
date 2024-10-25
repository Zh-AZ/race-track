using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MovingPointTarget : MonoBehaviour
{
    public Transform[] pointArray = new Transform[5];
    //public Transform point2;
    //public Transform point3;
    //public Transform point4;
    //public Transform point5;

    public float Speed = 1.0f;
    private bool Go = true;
    private Vector3 target;

    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Go)
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);

        //StartCoroutine(ChangeTarget());

        if (transform.position == target)
        {
            if (target != pointArray[pointArray.Length - 1].position)
            {
                target = pointArray[counter++].position;
            }
            else
            {
                target = pointArray[0].position;
                counter = 0;
            }
        }
    }

    IEnumerator ChangeTarget()
    {
        if (transform.position == target)
        {
            for (int i = 0; i < pointArray.Length; i++)
            {
                if (target == pointArray[pointArray.Length - 1].position)
                {
                    target = pointArray[0].position;
                }
                else
                {
                    target = pointArray[i + 1].position;
                }

                yield return null; // ќжидаем до следующего кадра
            }
        }
    }
}
