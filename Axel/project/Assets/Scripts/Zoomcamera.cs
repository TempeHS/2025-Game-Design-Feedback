using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoomcamera : MonoBehaviour
{

    [SerializeField]
    private float zoomFOV;
    [SerializeField]
    private float normalFOV;
    [SerializeField]
    private float zoomSpeed;


    private Camera cam;



    // Start is called before the first frame update
    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float targetFOV;

        if (CameraScripty.cameraZoomStatus == true)
        {
            targetFOV = zoomFOV;
        }
        else
        {
            targetFOV = normalFOV;
        }

        cam.fieldOfView = targetFOV;
    }
}
