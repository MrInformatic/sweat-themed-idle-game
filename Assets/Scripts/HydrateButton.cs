using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HydrateButton : MonoBehaviour
{
    private Button hydrateButton;

    public double hydrateAmmount;
    public Game Game;

    void Start()
    {
        hydrateButton = GetComponent<Button>();
        hydrateButton.onClick.AddListener(Hydrate);
    }

    // Update is called once per frame
    void Hydrate()
    {
        Game.HydrateAmmount(hydrateAmmount);
    }
}
