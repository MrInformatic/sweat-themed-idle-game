using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sweat : MonoBehaviour
{
    private Text SweatText;
    public Game game;

    void Start() 
    {
        SweatText = GetComponent<Text>();
    }

    void Update()
    {
        SweatText.text = game.sweat + " Liters"; 
    }
}
