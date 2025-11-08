using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapzoom : MonoBehaviour
{
/*public float zoomSpeed = 0.3f;
    public float minZoom = 6f;
    public float maxZoom = 20f;

    private RectTransform imageRectTransform;

    void Start()
    {
        imageRectTransform = GetComponent<RectTransform>();
        if (imageRectTransform == null)
        {
            Debug.LogError("ImageZoomViewer requires a RectTransform component on the GameObject.");
            enabled = false;
        }
    }

private Vector3 lastMousePosition;

    // Set these to your desired limits
    public Vector2 minPan = new Vector2(-500, -500);
    public Vector2 maxPan = new Vector2(500, 500);

    void Update()
    {
        // Zoom with scroll wheel
        float scrollDelta = Input.mouseScrollDelta.y;
        if (scrollDelta != 0)
        {
            Vector3 currentScale = imageRectTransform.localScale;
            float newScaleFactor = currentScale.x + scrollDelta * zoomSpeed;
            newScaleFactor = Mathf.Clamp(newScaleFactor, minZoom, maxZoom);
            imageRectTransform.localScale = new Vector3(newScaleFactor, newScaleFactor, 1f);
        }

        // Pan with right mouse button
        if (Input.GetMouseButtonDown(1))
        {
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            Vector2 newPos = imageRectTransform.anchoredPosition + new Vector2(delta.x, delta.y);

            // Clamp the position to boundaries
            newPos.x = Mathf.Clamp(newPos.x, minPan.x, maxPan.x);
            newPos.y = Mathf.Clamp(newPos.y, minPan.y, maxPan.y);

            imageRectTransform.anchoredPosition = newPos;
            lastMousePosition = Input.mousePosition;
        }
    }
    */
}
