using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{

    public AudioSource audioSource;
    
    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(audioSource.Play);
    }
}
