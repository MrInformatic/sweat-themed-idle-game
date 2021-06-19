using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sweat : MonoBehaviour
{
    private Text SweatText;
    public int SweatLevel;

    void Start() 
    {
        SweatText = GetComponent<Text>();
    }

    void Update()
    {
        SweatText.text = "Sweat: " + SweatLevel + " Liters"; 
    }
}
