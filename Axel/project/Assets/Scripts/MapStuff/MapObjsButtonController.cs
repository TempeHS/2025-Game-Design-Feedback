using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObjsButtonController : MonoBehaviour
{

    public GameObject Obj1CloseButton;
    public GameObject Obj2CloseButton;
    public GameObject Obj3CloseButton;
    public GameObject Obj4CloseButton;
    public GameObject Obj5CloseButton;
    public GameObject Obj6CloseButton;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjButtonsVisibility();
    }

    void ObjButtonsVisibility()
    {
        if (Map.Obj1PhotoView == true)
        {
            Obj1CloseButton.SetActive(true);
        }
        else
        {
            Obj1CloseButton.SetActive(false);
        }


        if (Map.Obj2PhotoView == true)
        {
            Obj2CloseButton.SetActive(true);
        }
        else
        {
            Obj2CloseButton.SetActive(false);
        }


        if (Map.Obj3PhotoView == true)
        {
            Obj3CloseButton.SetActive(true);
        }
        else
        {
            Obj3CloseButton.SetActive(false);
        }


        if (Map.Obj4PhotoView == true)
        {
            Obj4CloseButton.SetActive(true);
        }
        else
        {
            Obj4CloseButton.SetActive(false);
        }


        if (Map.Obj5PhotoView == true)
        {
            Obj5CloseButton.SetActive(true);
        }
        else
        {
            Obj5CloseButton.SetActive(false);
        }


        if (Map.Obj6PhotoView == true)
        {
            Obj6CloseButton.SetActive(true);
        }
        else
        {
            Obj6CloseButton.SetActive(false);
        }
    }


    public void ChangeObj1ViewBool1()
    {
        Map.Obj1PhotoView = true;
    }

    public void ChangeObj1ViewBool2()
    {
        Map.Obj1PhotoView = false;
    }



    public void ChangeObj2ViewBool1()
    {
        Map.Obj2PhotoView = true;
    }

    public void ChangeObj2ViewBool2()
    {
        Map.Obj2PhotoView = false;
    }



    public void ChangeObj3ViewBool1()
    {
        Map.Obj3PhotoView = true;
    }

    public void ChangeObj3ViewBool2()
    {
        Map.Obj3PhotoView = false;
    }



    public void ChangeObj4ViewBool1()
    {
        Map.Obj4PhotoView = true;
    }

    public void ChangeObj4ViewBool2()
    {
        Map.Obj4PhotoView = false;
    }



    public void ChangeObj5ViewBool1()
    {
        Map.Obj5PhotoView = true;
    }

    public void ChangeObj5ViewBool2()
    {
        Map.Obj5PhotoView = false;
    }



    public void ChangeObj6ViewBool1()
    {
        Map.Obj6PhotoView = true;
    }

    public void ChangeObj6ViewBool2()
    {
        Map.Obj6PhotoView = false;
    }
}

