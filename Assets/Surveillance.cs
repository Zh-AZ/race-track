using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surveillance : MonoBehaviour
{
    public Transform purpleCar;
    public Transform whiteCar;
    public Transform redCar;
    public Transform blueCar;

    public Camera[] cameras;
    public Camera RedCamera;
    public Camera BlackCamera;
    public Camera BlueCamera;

    public Transform[] transforms;

    float seconds = 0;

    // Start is called before the first frame update    // 9 14 19 23 31
    void Start()
    {
        cameras[0].gameObject.SetActive(true);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);
        cameras[5].gameObject.SetActive(false);
        cameras[6].gameObject.SetActive(false);
        cameras[7].gameObject.SetActive(false);
        cameras[8].gameObject.SetActive(false);
        cameras[9].gameObject.SetActive(false);
        cameras[10].gameObject.SetActive(false);
        cameras[11].gameObject.SetActive(false);
        cameras[12].gameObject.SetActive(false);
        cameras[13].gameObject.SetActive(false);
        cameras[14].gameObject.SetActive(false);
        cameras[15].gameObject.SetActive(false);

        RedCamera.gameObject.SetActive(false);
        BlackCamera.gameObject.SetActive(false);
        BlueCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transforms[0].LookAt(purpleCar);
        transforms[1].LookAt(purpleCar);
        transforms[2].LookAt(purpleCar);
        transforms[3].LookAt(purpleCar);
        transforms[4].LookAt(purpleCar);
        transforms[5].LookAt(purpleCar);
        transforms[6].LookAt(purpleCar);


        transforms[7].LookAt(whiteCar);
        transforms[8].LookAt(whiteCar);
        transforms[9].LookAt(whiteCar);
        transforms[10].LookAt(whiteCar);

        transforms[11].LookAt(blueCar);
        transforms[12].LookAt(blueCar);
        transforms[13].LookAt(blueCar);
        transforms[14].LookAt(blueCar);
        transforms[15].LookAt(blueCar);

        seconds += Time.deltaTime;

        
        if (seconds >= 9 && seconds < 10)
        {
            cameras[0].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(true);
            //cameras[1].gameObject.SetActive(true);
        }
        else if (seconds >= 10 && seconds < 15)
        {
            cameras[1].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(true);
        }
        if (seconds >= 15 && seconds < 21)
        {
            RedCamera.gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        //else if (seconds >= 14 && seconds < 19)
        //{
        //    cameras[1].gameObject.SetActive(false);
        //    cameras[2].gameObject.SetActive(true);
        //}
        else if (seconds >= 21 && seconds < 25)
        {
            cameras[1].gameObject.SetActive(false);
            RedCamera.gameObject.SetActive(false);

            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(true);
        }
        else if (seconds >= 25 && seconds < 30)
        {
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(true);
        }
        else if (seconds >= 30 && seconds < 40)
        {
            cameras[4].gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(true);
        }
        else if (seconds >= 40 && seconds < 47)
        {
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(true);
        }
        //
        else if (seconds >= 47 && seconds < 71.40)
        {
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(true);
        }
        else if (seconds >= 71.40 && seconds < 75)
        {
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(true);
        }
        else if (seconds >= 75 && seconds < 93)
        {
            cameras[8].gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(true);
        }
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
        else if (seconds >= 101.30 && seconds < 116)
        {
            cameras[10].gameObject.SetActive(false);
            cameras[11].gameObject.SetActive(true);
        }
        else if (seconds >= 116 && seconds < 125)
        {
            cameras[11].gameObject.SetActive(false);
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
            cameras[14].gameObject.SetActive(true);
        }
        else if (seconds >= 150 && seconds < 153)
        {
            cameras[14].gameObject.SetActive(false);
            BlueCamera.gameObject.SetActive(true);
        }
        else if (seconds >= 153 && seconds < 155)
        {
            BlueCamera.gameObject.SetActive(false);
            cameras[15].gameObject.SetActive(true);
        }
    }
}
