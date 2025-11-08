using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The reason we have a seperate map script is so that it appears only in the "van" scene.

public class Map : MonoBehaviour
{


    public Animator MapViewAnim;

    public Image Obj1MapPhoto;
    public Image Obj2MapPhoto;
    public Image Obj3MapPhoto;
    public Image Obj4MapPhoto;
    public Image Obj5MapPhoto;
    public Image Obj6MapPhoto;

    public static bool Obj1PhotoView = false;
    public static bool Obj2PhotoView = false;
    public static bool Obj3PhotoView = false;
    public static bool Obj4PhotoView = false;
    public static bool Obj5PhotoView = false;
    public static bool Obj6PhotoView = false;

//this is just the progression state stuff
    public GameObject Obj1MapPopup;
    public GameObject Obj2MapPopup;
    public GameObject Obj3MapPopup;
    public GameObject Obj4MapPopup;
    public GameObject Obj5MapPopup;
    public GameObject Obj6MapPopup;

    static public bool isMapOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Obj1MapPopup.SetActive(false);
        Obj2MapPopup.SetActive(false);
        Obj3MapPopup.SetActive(false);
        Obj4MapPopup.SetActive(false);
        Obj5MapPopup.SetActive(false);
        Obj6MapPopup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        MapViewAnim.SetBool("isMapOpen", isMapOpen);
        MapViewAnim.SetBool("Obj1PhotoView", Obj1PhotoView);
        MapViewAnim.SetBool("Obj2PhotoView", Obj2PhotoView);
        MapViewAnim.SetBool("Obj3PhotoView", Obj3PhotoView);
        MapViewAnim.SetBool("Obj4PhotoView", Obj4PhotoView);
        MapViewAnim.SetBool("Obj5PhotoView", Obj5PhotoView);
        MapViewAnim.SetBool("Obj6PhotoView", Obj6PhotoView);
        CheckProgressionState();
        SetObjMapPhotos();
    }

    void SetObjMapPhotos()//this is just setting the images from the photocapture script to the photos in this script
    {
        if (PhotoCapture.Obj1PhotoCapture != null && Obj1MapPhoto.sprite != PhotoCapture.Obj1PhotoCapture)
        {
            Obj1MapPhoto.sprite = PhotoCapture.Obj1PhotoCapture;
        }

        if (PhotoCapture.Obj2PhotoCapture != null && Obj2MapPhoto.sprite != PhotoCapture.Obj2PhotoCapture)
        {
            Obj2MapPhoto.sprite = PhotoCapture.Obj2PhotoCapture;
        }

        if (PhotoCapture.Obj3PhotoCapture != null && Obj3MapPhoto.sprite != PhotoCapture.Obj3PhotoCapture)
        {
            Obj3MapPhoto.sprite = PhotoCapture.Obj3PhotoCapture;
        }

        if (PhotoCapture.Obj4PhotoCapture != null && Obj4MapPhoto.sprite != PhotoCapture.Obj4PhotoCapture)
        {
            Obj4MapPhoto.sprite = PhotoCapture.Obj4PhotoCapture;
        }

        if (PhotoCapture.Obj5PhotoCapture != null && Obj5MapPhoto.sprite != PhotoCapture.Obj5PhotoCapture)
        {
            Obj5MapPhoto.sprite = PhotoCapture.Obj5PhotoCapture;
        }

        if (PhotoCapture.Obj6PhotoCapture != null && Obj6MapPhoto.sprite != PhotoCapture.Obj6PhotoCapture)
        {
            Obj6MapPhoto.sprite = PhotoCapture.Obj6PhotoCapture;
        }

    }

    void CheckProgressionState() //This is for whether or not the progression stage in the game is true or not
    {
        if (Progression.obj1 == true)
        {
            Obj1MapPopup.SetActive(true);
        }
        else
        {
            Obj1MapPopup.SetActive(false);
        }


        if (Progression.obj2 == true)
        {
            Obj2MapPopup.SetActive(true);
        }
        else
        {
            Obj2MapPopup.SetActive(false);
        }


        if (Progression.obj3 == true)
        {
            Obj3MapPopup.SetActive(true);
        }
        else
        {
            Obj3MapPopup.SetActive(false);
        }


        if (Progression.obj4 == true)
        {
            Obj4MapPopup.SetActive(true);
        }
        else
        {
            Obj4MapPopup.SetActive(false);
        }


        if (Progression.obj5 == true)
        {
            Obj5MapPopup.SetActive(true);
        }
        else
        {
            Obj5MapPopup.SetActive(false);
        }


        if (Progression.obj6 == true)
        {
            Obj6MapPopup.SetActive(true);
        }
        else
        {
            Obj6MapPopup.SetActive(false);
        }
    }

}
