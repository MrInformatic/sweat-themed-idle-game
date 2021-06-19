using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureUnlock : MonoBehaviour
{
    public Game game;
    public double unlockTemperature;

    void Start()
    {
        InvokeRepeating("Tick", 0.0f, 1.0f);
    }

    void Tick()
    {
        if(game.temperature >= unlockTemperature) {
            gameObject.SetActive(true);
        }else {
            gameObject.SetActive(false);
        }
    }
}
