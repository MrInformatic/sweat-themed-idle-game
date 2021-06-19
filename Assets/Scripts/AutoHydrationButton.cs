using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoHydrationButton : MonoBehaviour
{
    private Button autoHydrateButton;

    public double autoHydrateAmmount;
    public double price;
    public Game Game;

    void Start()
    {
        autoHydrateButton = GetComponent<Button>();
        autoHydrateButton.onClick.AddListener(AutoHydrate);
    }

    void AutoHydrate()
    {
        if(Game.Buy(price)) {
            Game.AutoHydrateAmmount(autoHydrateAmmount);
        }
    }
}
