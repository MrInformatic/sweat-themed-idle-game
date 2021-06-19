using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HydrateButton : MonoBehaviour
{
    private Button hydrateButton;

    public double hydrateAmmount;
    public double price;
    public Game Game;

    void Start()
    {
        hydrateButton = GetComponent<Button>();
        hydrateButton.onClick.AddListener(Hydrate);
    }

    void Hydrate()
    {
        if(Game.Buy(price)) {
            Game.HydrateAmmount(hydrateAmmount);
        }
    }
}
