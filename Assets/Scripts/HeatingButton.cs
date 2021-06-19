using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatingButton : MonoBehaviour
{
    private Button heatingButton;

    public double heatingAmmount;
    public double price;
    public Game Game;

    void Start()
    {
        heatingButton = GetComponent<Button>();
        heatingButton.onClick.AddListener(Heat);
    }

    void Heat()
    {
        if(Game.Buy(price)) {
            Game.HeatAmmount(heatingAmmount);
        }
    }
}
