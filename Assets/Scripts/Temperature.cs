using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    private Text TemperaturText;
    public Game game;

    void Start()
    {
        TemperaturText = GetComponent<Text>();
    }

    void Update()
    {
        TemperaturText.text = game.temperature + "C"; 
    }
}
