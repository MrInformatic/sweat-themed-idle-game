using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public double maxHydration = 5.0;
    public double hydration = 5.0;

    public double sweat = 0;
    public double baseTemperature = 20;
    public double temperature = 30;
    public double autoHydration = 0;
    public double autoHeating = 0;
    public string[] items;
    public float gameSpeed = 1;

    public bool isGameOver = false;

    private void Awake()
    {
        InvokeRepeating("GameTick", 0.0f, gameSpeed);
    }

    private void Update()
    {
        maxHydration = (temperature - baseTemperature) / 4.0;
    }

    private void GameTick() {
        this.temperature += autoHeating;

        double sweatSpeed = GetSweatSpeed();
        this.hydration -= sweatSpeed;
        this.sweat += sweatSpeed;

        this.hydration = Math.Min(this.hydration + autoHydration, maxHydration);

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
        Invoke("RestartGame", 8);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void HydrateAmmount(double ammount) {
        this.hydration = Math.Min(this.hydration + ammount, this.maxHydration);
    }

    public void AutoHydrateAmmount(double ammount) {
        this.autoHydration += ammount;
    }

    public void HeatAmmount(double ammount) {
        this.temperature += ammount;
    }

    public void AutoHeatAmmount(double ammount) {
        this.autoHeating += ammount;
    }

    public bool Buy(double price) {
        if(sweat > price && !isGameOver) {
            sweat -= price;
            return true;
        }
        return false;
    }
}