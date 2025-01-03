using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surveillance : MonoBehaviour
{
    public Transform purpleCar;
    public Transform whiteCar;
    public Transform redCar;
    public Transform blueCar;
    public Transform[] transforms;

    public Camera[] cameras;
    public Camera RedCamera;
    public Camera BlackCamera;
    public Camera BlueCamera;
    public Camera HeliCamera;

    float seconds = 0;

    // Start is called before the first frame update    
    void Start()
    {
        cameras[0].gameObject.SetActive(true);

        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        RedCamera.gameObject.SetActive(false);
        BlackCamera.gameObject.SetActive(false);
        BlueCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transforms.Length; i++)
        {
            if (i <= 6)
            {
                transforms[i].LookAt(purpleCar);
            }
            else if (i > 6 && i <= 10)
            {
                transforms[i].LookAt(whiteCar);
            }
            else
            {
                transforms[i].LookAt(blueCar);
            }
        }

        seconds += Time.deltaTime;

        // ������ ����� �����
        // ������� 1 Red
        if (seconds >= 5 && seconds < 7)
        {
            cameras[0].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(true);
        }
        //
        else if (seconds >= 7 && seconds < 10)
        {
            RedCamera.gameObject.SetActive(false);
            cameras[0].gameObject.SetActive(true);
        }
        else if (seconds >= 10 && seconds < 17.50)
        {
            cameras[0].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 17.50 && seconds < 21)
        {
            RedCamera.gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        else if (seconds >= 21 && seconds < 25)
        {
            cameras[1].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(false);

            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(true);
        }
        else if (seconds >= 25 && seconds < 26)
        {
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(true);
        }

        else if (seconds >= 26 && seconds < 31)
        {
            cameras[4].gameObject.SetActive(false);
            HeliCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 31 && seconds < 40)
        {
            HeliCamera.gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(true);
        }
        // ������� ������� Red
        else if (seconds >= 40 && seconds < 43)
        {
            cameras[5].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(true);
        }
        //
        else if (seconds >= 43 && seconds < 47)
        {
            RedCamera.gameObject.SetActive(true);
            cameras[6].gameObject.SetActive(true);
        }
        
        // Black
        else if (seconds >= 47 && seconds < 54) // seconds < 71.40
        {
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(true);
        }
        // ������ ������� Black
        else if (seconds >= 54 && seconds < 56)
        {
            cameras[7].gameObject.SetActive(false);
            BlackCamera.gameObject.SetActive(true);
        }
        //----------
        else if (seconds >= 56 && seconds < 75)
        {
            BlackCamera.gameObject.SetActive(false);
            HeliCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 75 && seconds < 87) 
        {
            HeliCamera.gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(true);
        }
        else if (seconds >= 87 && seconds < 91)
        {
            cameras[9].gameObject.SetActive(false);
            BlackCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 91 && seconds < 93)
        {
            BlackCamera.gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(true);
        }
        //----------
        else if (seconds >= 93 && seconds < 95)
        {
            cameras[9].gameObject.SetActive(false);
            BlackCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 95 && seconds < 98)
        {
            BlackCamera.gameObject.SetActive(true);
            cameras[7].gameObject.SetActive(true);
        }
        else if (seconds >= 98 && seconds < 101.30)
        {
            cameras[7].gameObject.SetActive(false);
            cameras[10].gameObject.SetActive(true);
        }
        //
        else if (seconds >= 101.30 && seconds < 105)
        {
            cameras[10].gameObject.SetActive(false);
            cameras[11].gameObject.SetActive(true);
        }

        else if (seconds >= 105 && seconds < 116)
        {
            cameras[11].gameObject.SetActive(false);
            HeliCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 116 && seconds < 125)
        {
            HeliCamera.gameObject.SetActive(false);
            cameras[12].gameObject.SetActive(true);
        }
        else if (seconds >= 125 && seconds < 128)
        {
            cameras[12].gameObject.SetActive(false);
            BlueCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 128 && seconds < 140)
        {
            BlueCamera.gameObject.SetActive(false);
            cameras[13].gameObject.SetActive(true);
        }
        else if (seconds >= 140 && seconds < 145)
        {
            cameras[13].gameObject.SetActive(false);
            BlueCamera.gameObject.SetActive(true);
        }

        else if (seconds >= 145 && seconds < 150)
        {
            BlueCamera.gameObject.SetActive(false);
            HeliCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 150 && seconds < 153)
        {
            HeliCamera.gameObject.SetActive(false);
            BlueCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 153 && seconds < 155)
        {
            BlueCamera.gameObject.SetActive(false);
            cameras[15].gameObject.SetActive(true);
        }
        else if (seconds >= 155)
        {
            cameras[15].gameObject.SetActive(false);
            HeliCamera.gameObject.SetActive(true);
        }
    }
}
