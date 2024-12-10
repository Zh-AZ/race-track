using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surveillance : MonoBehaviour
{
    public Transform purpleCar;

    public Camera[] cameras;
    public Camera RedCamera;
    public Transform[] transforms;

    float seconds = 0;

    // Start is called before the first frame update    // 9 14 19 23 31
    void Start()
    {
        
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


        seconds += Time.deltaTime;

        
        if (seconds >= 9 && seconds < 14)
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        else if (seconds >= 14 && seconds < 15)
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
        else if (seconds >= 40)
        {
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(true);
        }


        //switch (seconds)
        //{
        //    case 9:
        //        cameras[0].gameObject.SetActive(false);
        //        cameras[1].gameObject.SetActive(true);
        //        break;
        //    case 14:
        //        cameras[1].gameObject.SetActive(false);
        //        cameras[2].gameObject.SetActive(true);
        //        break;
        //    case 19:
        //        cameras[2].gameObject.SetActive(false);
        //        cameras[3].gameObject.SetActive(true);
        //        break;
        //    case 23:
        //        cameras[3].gameObject.SetActive(false);
        //        cameras[4].gameObject.SetActive(true);
        //        break;
        //    case 31:
        //        cameras[4].gameObject.SetActive(false);
        //        cameras[5].gameObject.SetActive(true);
        //        break; 
        //}
    }
}
