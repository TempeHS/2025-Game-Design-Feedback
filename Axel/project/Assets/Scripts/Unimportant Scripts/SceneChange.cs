using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public Animator sceneFadeInAndOut;

    public static bool SceneFadeOutToBlack = false;

    public DayTimer dayTimerScriptCall;


    void Start()
    {
        SceneFadeOutToBlack = false;
    }

    void Update()
    {
        sceneFadeInAndOut.SetBool("SceneFadeOutToBlack", SceneFadeOutToBlack);
        mouseLockState();
    }


    public void changeToMenuScene()
    {
        StartCoroutine(FadeIntoMenuScene());
    }

    public void changeToOutsideScene1()
    {
        StartCoroutine(FadeOutOfVanScene());
    }

    public void changeToVanScene()
    {
        StartCoroutine(FadeOutOfOutsideScene());
    }

    public void ChangeToVanFromMenuScene()
    {
        StartCoroutine(FadeOutOfMenuScene());
    }

    public void changeToOutsideScene2()
    {
        StartCoroutine(FadeOutOfVanSceneEnviro2());
    }


public void mouseLockState()
{
    if (SceneManager.GetActiveScene().name == "MenuScreen")//enabling mouse if it is in the menu screen
    {
        Cursor.lockState = CursorLockMode.None;
    }
}



    IEnumerator FadeIntoMenuScene()//changing to menu scene
    {
        SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1f);
        Progression.isInVan = false;
        SceneManager.LoadSceneAsync(0);
    }

    IEnumerator FadeOutOfMenuScene()//changing to van scene
    {
        SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1f);
        Progression.isInVan = true;
        SceneManager.LoadSceneAsync(2);
    }

    IEnumerator FadeOutOfOutsideScene()//changing to van scene
    {
        SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1f);
        Progression.isInVan = true;
        SceneManager.LoadSceneAsync(2);
    }

    IEnumerator FadeOutOfVanScene()//changing to outside scene
    {
        SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1f);
        Progression.isInVan = false;
        SceneManager.LoadSceneAsync(1);
        DayTimer.timerRunning = true;//starts the timer when you leave the van
    }

    IEnumerator FadeOutOfVanSceneEnviro2()//changing to outside scene
    {
        SceneFadeOutToBlack = true;
        yield return new WaitForSecondsRealtime(1f);
        Progression.isInVan = false;
        SceneManager.LoadSceneAsync(3);
        DayTimer.timerRunning = true;//starts the timer when you leave the van
    }


}