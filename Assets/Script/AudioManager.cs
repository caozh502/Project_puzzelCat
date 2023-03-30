using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGM_Source;
    public Slider volumeSlider;

    private void Update() {
        BGM_Source.volume = volumeSlider.value;
    }

}
