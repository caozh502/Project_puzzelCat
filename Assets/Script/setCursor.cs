using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCursor : MonoBehaviour
{
    public Texture2D cursorSticker;
    public Vector2 cursorPosition;
    public CursorMode cursorMode;
    public AudioSource mouseClick;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorSticker, cursorPosition, cursorMode);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseClick.Play();
        }
    }
}
