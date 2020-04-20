using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CameraTP;
    public GameObject CameraFP;
    public bool whichCam = false;

    private void Update()
    {
        if (Input.GetKeyUp("c"))
        {
            if (whichCam == false)
            {
                whichCam = true;
            }
            else if (whichCam == true)
            {
                whichCam = false;
            }
        }
        if (whichCam == false)
        {
            CameraFP.SetActive(true);
            CameraTP.SetActive(false);
        }

        if (whichCam == true)
        {
            CameraFP.SetActive(false);
            CameraTP.SetActive(true);
        }
    }
}
