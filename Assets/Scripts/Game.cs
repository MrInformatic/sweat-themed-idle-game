using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public double maxHydration = 5.0;
    public double hydration = 5.0;

    public double sweat = 0;
    public double baseTemperature = 20;
    public double temperature = 30;
    public string[] items;
    public float gameSpeed = 1;

    private bool isGameOver = false;

    private void Awake()
    {
        InvokeRepeating("GameTick", 0.0f, gameSpeed);
    }

    private void GameTick() {
        double sweatSpeed = GetSweatSpeed();
        this.hydration -= sweatSpeed;
        this.sweat += sweatSpeed;

        if (this.IsGameEnding()) {
            this.GameOver();
        }
    }

    private double GetSweatSpeed() {
        return (temperature - baseTemperature) / 20.0;
    }

    private bool IsGameEnding() {
        return this.hydration <= 0;
    }

    private void GameOver() {
        this.isGameOver = true;
        // Should destroy class/change scene or something here.
        Destroy(this);
    }

    public void HydrateAmmount(double ammount) {
        this.hydration = Math.Min(this.hydration + ammount, this.maxHydration);
    }
}