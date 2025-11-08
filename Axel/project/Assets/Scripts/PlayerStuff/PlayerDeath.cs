using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDeath : MonoBehaviour
{

    public SceneChange sceneChangeScriptCall;

    public DayTimer scriptCallForDayTimer;

    public TextMeshProUGUI youDiedText;


    static public bool deathCheckBool;// a bool that makes sure the death sequence can't repeat over and over again


    // Start is called before the first frame update
    void Start()
    {
        youDiedText.text = "   ";
        deathCheckBool = true; //this means that the bool will become true every time the script restarts, it works with the code
    }

    // Update is called once per frame
    void Update()
    {
        checkForPlayerDeath();
    }


void checkForPlayerDeath()
{
    if(deathCheckBool == true)// all death conditions must be inside this if statement to prevent scenes from loading multiple times
    {
    
        if (Progression.isInVan == false && DayTimer.timerRunning == false)// triggering death sequence for outside environment 1
        {
            OutsideDeathEnviro1();
        }
    
        if (Progression.isInVan == true && DayTimer.canGoOutside == false && Progression.Day3 == true)
        {
            if (Progression.obj1 == true && Progression.obj2 == true && Progression.obj3 == true && Progression.obj4 == true && Progression.obj5 == true && Progression.obj6 == true)
            {
                //this is just here so that there can be an "else" statement
            }
            else
            {
                //in van death sequence
                VanDeath();
            }
        }
    }
}


//calls for the coroutines
    void OutsideDeathEnviro1()
    {
        StartCoroutine(OutsideDeathE1());
    }

    void VanDeath()
    {
        StartCoroutine(InVanDeath());
    }

    void OutsideDeathEnviro2()
    {
        StartCoroutine(OutsideDeathE2());
    }



//coroutines
    IEnumerator OutsideDeathE1()
    {
        deathCheckBool = false;
        youDiedText.text = "You were discovered.";
        SceneChange.SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1.5f);
        youDiedText.text = "  ";
        yield return new WaitForSecondsRealtime(2f);
        Progression.obj1 = false;
        Progression.obj2 = false;
        Progression.obj3 = false;
        Progression.obj4 = false;
        Progression.obj5 = false;
        Progression.obj6 = false;
        Progression.Day1 = true;
        Progression.Day2 = false;
        Progression.Day3 = false;
        DayTimer.timerRunning = false;
        scriptCallForDayTimer.ResetTimer();
        DayTimer.canGoOutside = true;
        sceneChangeScriptCall.changeToMenuScene();
    }

    IEnumerator InVanDeath()
    {
        deathCheckBool = false;
        youDiedText.text = "You did not gather enough photos.";
        SceneChange.SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1.5f);
        youDiedText.text = "  ";
        yield return new WaitForSecondsRealtime(2f);
        Progression.obj1 = false;//resetting objects
        Progression.obj2 = false;
        Progression.obj3 = false;
        Progression.obj4 = false;
        Progression.obj5 = false;
        Progression.obj6 = false;
        Progression.Day1 = true;//resetting days
        Progression.Day2 = false;
        Progression.Day3 = false;
        DayTimer.timerRunning = false;
        scriptCallForDayTimer.ResetTimer();
        DayTimer.canGoOutside = true;
        sceneChangeScriptCall.changeToMenuScene();
    }

    IEnumerator OutsideDeathE2()
    {
        deathCheckBool = false;
        youDiedText.text = "You were discovered.";
        SceneChange.SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1.5f);
        youDiedText.text = "  ";
        yield return new WaitForSecondsRealtime(2f);
        Progression.obj1 = false;//resetting objects
        Progression.obj2 = false;
        Progression.obj3 = false;
        Progression.obj4 = false;
        Progression.obj5 = false;
        Progression.obj6 = false;
        Progression.Day1 = true;//resetting days
        Progression.Day2 = false;
        Progression.Day3 = false;
        DayTimer.timerRunning = false;
        scriptCallForDayTimer.ResetTimer();
        DayTimer.canGoOutside = true;
        sceneChangeScriptCall.changeToMenuScene();
    }
}
