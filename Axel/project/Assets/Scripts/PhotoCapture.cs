using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhotoCapture : MonoBehaviour
{

    [Header("Photo Taker")]
    [SerializeField] private Image photoDisplayArea;
    [SerializeField] private GameObject photoFrame;
    public float photoDisplayDuration = 2f;
    public float nextTimeToPhotoDissapear;

    public Texture2D screenCapture;

    public Sprite lastCapturedPhoto { get; private set; } //getting the "photosprite" sprite transferred out of the "showphoto" method so it is usable elsewhere in the script

    public static Sprite Obj1PhotoCapture;
    public static Sprite Obj2PhotoCapture;
    public static Sprite Obj3PhotoCapture;
    public static Sprite Obj4PhotoCapture;
    public static Sprite Obj5PhotoCapture;
    public static Sprite Obj6PhotoCapture;

    private bool Obj1CheckBool = true; // Bools that close off the method that transfers the "Obj1photocapture" to the last captured photo once it has bveen performed.
    private bool Obj2CheckBool = true;
    private bool Obj3CheckBool = true;
    private bool Obj4CheckBool = true;
    private bool Obj5CheckBool = true;
    private bool Obj6CheckBool = true;


    private void Start()
    {
        screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        photoFrame.SetActive(false);
    }

    public void takeScreenshot()
    {
        //take screenshot
        StartCoroutine(CapturePhoto());
    }

    private void Update()
    {
        if (Time.time >= nextTimeToPhotoDissapear) // making the photo dissapear after a timer
        {
            photoFrame.SetActive(false);
        }
    }

IEnumerator CapturePhoto()
{
    yield return new WaitForEndOfFrame();

    // Create a temporary RenderTexture
    RenderTexture renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
    Camera captureCamera = Camera.main; // Replace with your dedicated camera if needed
    captureCamera.targetTexture = renderTexture;

    // Render the camera's view
    captureCamera.Render();

    // Set the active RenderTexture and read pixels
    RenderTexture.active = renderTexture;
    Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);
    screenCapture.ReadPixels(regionToRead, 0, 0, false);
    screenCapture.Apply();

    // Clean up
    captureCamera.targetTexture = null;
    RenderTexture.active = null;
    Destroy(renderTexture);

    ShowPhoto();
    nextTimeToPhotoDissapear = Time.time + photoDisplayDuration; 
}


    void ShowPhoto()
    {
        Sprite photoSprite = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);  //this is converting the texture2d to a sprite so that it can be used as  UI element
        //photo area = photoSprite
        photoDisplayArea.sprite = photoSprite;
        photoFrame.SetActive(true);
        lastCapturedPhoto = photoSprite; // Store the sprite for later use

    if (Progression.obj1 == true && Obj1CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj1Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj1Texture2D.SetPixels(screenCapture.GetPixels());
        Obj1Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj1MapPhotoSprite = Sprite.Create(Obj1Texture2D, new Rect(0.0f, 0.0f, Obj1Texture2D.width, Obj1Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj1PhotoCapture = Obj1MapPhotoSprite;
        Obj1CheckBool = false;
        Debug.Log("Obj1PhotoCapture assigned!");
    }

        if (Progression.obj2 == true && Obj2CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj2Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj2Texture2D.SetPixels(screenCapture.GetPixels());
        Obj2Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj2MapPhotoSprite = Sprite.Create(Obj2Texture2D, new Rect(0.0f, 0.0f, Obj2Texture2D.width, Obj2Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj2PhotoCapture = Obj2MapPhotoSprite;
        Obj2CheckBool = false;
        Debug.Log("Obj2PhotoCapture assigned!");
    }

        if (Progression.obj3 == true && Obj3CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj3Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj3Texture2D.SetPixels(screenCapture.GetPixels());
        Obj3Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj3MapPhotoSprite = Sprite.Create(Obj3Texture2D, new Rect(0.0f, 0.0f, Obj3Texture2D.width, Obj3Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj3PhotoCapture = Obj3MapPhotoSprite;
        Obj3CheckBool = false;
        Debug.Log("Obj3PhotoCapture assigned!");
    }

        if (Progression.obj4 == true && Obj4CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj4Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj4Texture2D.SetPixels(screenCapture.GetPixels());
        Obj4Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj4MapPhotoSprite = Sprite.Create(Obj4Texture2D, new Rect(0.0f, 0.0f, Obj4Texture2D.width, Obj4Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj4PhotoCapture = Obj4MapPhotoSprite;
        Obj4CheckBool = false;
        Debug.Log("Obj4PhotoCapture assigned!");
    }

        if (Progression.obj5 == true && Obj5CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj5Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj5Texture2D.SetPixels(screenCapture.GetPixels());
        Obj5Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj5MapPhotoSprite = Sprite.Create(Obj5Texture2D, new Rect(0.0f, 0.0f, Obj5Texture2D.width, Obj5Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj5PhotoCapture = Obj5MapPhotoSprite;
        Obj5CheckBool = false;
        Debug.Log("Obj5PhotoCapture assigned!");
    }

        if (Progression.obj6 == true && Obj6CheckBool == true)
    {
        // Create a new Texture2D and copy the pixels from screenCapture
        Texture2D Obj6Texture2D = new Texture2D(screenCapture.width, screenCapture.height, screenCapture.format, false);
        Obj6Texture2D.SetPixels(screenCapture.GetPixels());
        Obj6Texture2D.Apply();

        // Create a new Sprite from the unique Texture2D
        Sprite Obj6MapPhotoSprite = Sprite.Create(Obj6Texture2D, new Rect(0.0f, 0.0f, Obj6Texture2D.width, Obj6Texture2D.height), new Vector2(0.5f, 0.5f), 100.0f);

        Obj6PhotoCapture = Obj6MapPhotoSprite;
        Obj6CheckBool = false;
        Debug.Log("Obj6PhotoCapture assigned!");
    }
    }


}
