using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoHeatingButton : MonoBehaviour
{
    private Button autoHeatButton;

    public double autoHeatAmmount;
    public double price;
    public Game Game;

    void Start()
    {
        autoHeatButton = GetComponent<Button>();
        autoHeatButton.onClick.AddListener(AutoHeat);
    }

    void AutoHeat()
    {
        if(Game.Buy(price)) {
            Game.AutoHeatAmmount(autoHeatAmmount);
        }
    }
}
