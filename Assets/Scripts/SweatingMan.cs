using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SweatingMan : MonoBehaviour
{
    public double[] Temperatures;
    public Sprite[] Textures;
    
    public Sprite Dead;

    public Game Game;

    public Image image;


    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Game.isGameOver) {
            image.sprite = Dead;
        } else {
            
            for(int i = 0; i < Temperatures.Length; i++) {
                if(Game.temperature < Temperatures[i]) {
                    image.sprite = Textures[i];
                    break;
                }
            }
            
        }
    }
}
