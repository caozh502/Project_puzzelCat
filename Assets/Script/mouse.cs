using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public AudioSource meow;

    private void OnMouseUpAsButton()
    {
        Debug.Log("mouse click");
        meow.Play();
    }
    
}
