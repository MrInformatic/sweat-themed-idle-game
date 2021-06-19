using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweatUnlock : MonoBehaviour
{
    public Game game;
    public double unlockSweat;

    void Start()
    {
        InvokeRepeating("Tick", 0.0f, 1.0f);
    }

    void Tick()
    {
        if(game.sweat >= unlockSweat) {
            gameObject.SetActive(true);
        }else {
            gameObject.SetActive(false);
        }
    }
}
