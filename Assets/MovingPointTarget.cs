using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MovingPointTarget : MonoBehaviour
{
    public Transform[] pointArray = new Transform[19];

    public float Speed = 1.0f;
    private bool Go = true;
    private Vector3 target;
    public bool IsAchieve = false;
    public int Lap = 5;
    public int LapCount = 0;

    private int indexCount;

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

        if (transform.position == target)
        {
            if (target != pointArray[pointArray.Length - 1].position)
            {
                target = pointArray[indexCount++].position;

                if (transform.position == pointArray[5].position)
                {
                    Lap = 5;
                }
                else if (transform.position == pointArray[10].position)
                {
                    Lap = 10;
                }
                else if (transform.position == pointArray[15].position)
                {
                    Lap = 15;
                }
                //else if (transform.position == pointArray[19].position)
                //{
                //    Lap = 20;
                //}
            }
            else
            {
                target = pointArray[0].position;
                indexCount = 0;
                Lap = 0;
                LapCount = 0;
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
