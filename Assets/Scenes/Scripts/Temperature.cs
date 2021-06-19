using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    private Text TemperaturText;
    public int TemperaturValue = 40;

    void Start()
    {
        TemperaturText = GetComponent<Text>();
    }

    void Update()
    {
        TemperaturText.text = TemperaturValue + "C"; 
    }
}
