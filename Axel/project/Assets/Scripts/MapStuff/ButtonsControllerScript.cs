using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonsControllerScript : MonoBehaviour
{

    public GameObject closeMapButton;
    public GameObject openMapButton;
    public GameObject BedButton;
    public GameObject GoToSleepButton;
    public GameObject CancelSleepButton;
    public GameObject areYouSureBackground;
    public GameObject vanDoorButton;

    public bool areObjButtonsOpen = false;
    public bool isAreYouSureScreenOpen = false;
    public bool GoToSleep = false;
    public bool PlaySleepAnimation = false;
    public bool PlayScreenFadeSleepAnimation = false;

    public Animator vanPlayerAnim;
    public Animator vanBlackScreenOverlay;

    public TextMeshProUGUI areYouSureText;
    public TextMeshProUGUI DayNumberText;

    public DayTimer dayTimerScriptReference;


    public void changeMapViewBool1()
    {
        Map.isMapOpen = true;
    }

    public void changeMapViewBool2()
    {
        Map.isMapOpen = false;
    } 


    public void changeAreYouSureBool1() //this is just changing weather or not the "areyousure" screen is open
    {
        isAreYouSureScreenOpen = true;
    }

    public void changeAreYouSureBool2()
    {
        isAreYouSureScreenOpen = false;
    }

    public void changeGoToSleepBool()
    {
        GoToSleep = true;
    }




    // Start is called before the first frame update
    void Start()
    {
        closeMapButton.SetActive(false);
        GoToSleepButton.SetActive(false);
        CancelSleepButton.SetActive(false);
        areYouSureBackground.SetActive(false);
        areYouSureText.text = "  ";
        DayNumberText.text = "  ";
    }

    // Update is called once per frame
    void Update()
    {
        closeMapButtonVisibility();
        openMapButtonVisibility();
        AreAnyObjButtonsOpen();
        areYouSureVisibility();
        checkIfGoingToSleep();
        goOutsideStatus();
        vanPlayerAnim.SetBool("PlaySleepAnimation", PlaySleepAnimation);
        vanBlackScreenOverlay.SetBool("PlayScreenFadeSleepAnimation", PlayScreenFadeSleepAnimation);
        bedButtonVisibility();
    }

IEnumerator ChangeDay2()
{
    yield return new WaitForSecondsRealtime(1.35f);
    PlayScreenFadeSleepAnimation = true;//play fade out animation
    yield return new WaitForSecondsRealtime(3f); // waiting for fade animation to finish
    DayNumberText.text = "Day 2";//display "day 2" text
    yield return new WaitForSecondsRealtime(2f);
    DayNumberText.text = "  ";//get rid of "day 2" text
    yield return new WaitForSecondsRealtime(2f);
    dayTimerScriptReference.ResetTimer();//resetting the timer
    DayTimer.canGoOutside = true; //allowing the player to now go outside
    PlaySleepAnimation = false;
    Progression.Day2 = true;
    Progression.Day1 = false;
    yield return new WaitForSecondsRealtime(2f);
    PlayScreenFadeSleepAnimation = false;
    //play fade in animation
}

IEnumerator ChangeDay3()
{
    yield return new WaitForSecondsRealtime(1.35f);
    PlayScreenFadeSleepAnimation = true;//play fade out animation
    yield return new WaitForSecondsRealtime(3f); // waiting for fade animation to finish
    DayNumberText.text = "Day 3";//display "day 3" text
    yield return new WaitForSecondsRealtime(2f);
    DayNumberText.text = "  ";//get rid of "day 3" text
    yield return new WaitForSecondsRealtime(2f);
    dayTimerScriptReference.ResetTimer();//resetting the timer
    DayTimer.canGoOutside = true; //allowing the player to now go outside
    PlaySleepAnimation = false;
    Progression.Day3 = true;
    Progression.Day2 = false;
    yield return new WaitForSecondsRealtime(2f);
    PlayScreenFadeSleepAnimation = false;
    //play fade in animation
}

    void goOutsideStatus()
    {
        if (DayTimer.canGoOutside == false)
        {
            vanDoorButton.SetActive(false);
        }
        else
        {
            vanDoorButton.SetActive(true);
        }
    }

    void bedButtonVisibility()// this is saying "if you can go outside, you can't go to sleep"
    {
        if (DayTimer.canGoOutside == false && Progression.Day3 == false)
        {
            BedButton.SetActive(true);
        }
        else
        {
            BedButton.SetActive(false);
        }
    }

    void areYouSureVisibility()
    {
        if (isAreYouSureScreenOpen == true && GoToSleep == false)
        {
            GoToSleepButton.SetActive(true);
            CancelSleepButton.SetActive(true);
            areYouSureBackground.SetActive(true);
            areYouSureText.text = "Are you sure you want to go to sleep? This will start the next day.";
        }
        else 
        {
            GoToSleepButton.SetActive(false);
            CancelSleepButton.SetActive(false);
            areYouSureBackground.SetActive(false);
            areYouSureText.text = "  ";
        }
    }

    void checkIfGoingToSleep()
    {
        if (GoToSleep == true && Progression.Day1 == true)
        {
            PlaySleepAnimation = true; //play zoom out animation
            StartCoroutine(ChangeDay2());
            isAreYouSureScreenOpen = false;
            GoToSleep = false;
        }
    
        if (GoToSleep == true && Progression.Day2 == true)
        {
            PlaySleepAnimation = true; //play zoom out animation
            StartCoroutine(ChangeDay3());
            isAreYouSureScreenOpen = false;
            GoToSleep = false;
        }

        if (Progression.Day3 == true)
        {
            //disabling the bedbutton has been moved to the "bedbuttonvisibility" method
        }
    }


    void closeMapButtonVisibility()
    {
        if (Map.isMapOpen == true && areObjButtonsOpen == false)
        {
            closeMapButton.SetActive(true);
        }
        else
        {
            closeMapButton.SetActive(false);
        }
    }
    
        void openMapButtonVisibility()
    {
            if (Map.isMapOpen == true)
        {
            openMapButton.SetActive(false);
        }
        else
        {
            if (isAreYouSureScreenOpen == false && PlaySleepAnimation == false)
            {
                openMapButton.SetActive(true);
            }
            else
            {
                openMapButton.SetActive(false);
            }
        }
    }

    void AreAnyObjButtonsOpen()
    {
        if (Map.Obj1PhotoView == true || Map.Obj2PhotoView == true || Map.Obj3PhotoView == true || Map.Obj4PhotoView == true || Map.Obj5PhotoView == true || Map.Obj6PhotoView == true)
        {
            areObjButtonsOpen = true;
        }
        else
        {
            areObjButtonsOpen = false;
        }
    }

}

