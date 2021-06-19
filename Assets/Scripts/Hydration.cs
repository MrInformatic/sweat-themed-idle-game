using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hydration : MonoBehaviour
{
    private Slider HydraionSlider;
    public Game game;
    
    void Start()
    {
        HydraionSlider = GetComponent<Slider>();
    }

    void Update()
    {
        HydraionSlider.value = (float) game.hydration;
        HydraionSlider.maxValue = (float) game.maxHydration;
    }
}
