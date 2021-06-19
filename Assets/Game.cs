using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int sweat = 0;
    public int temperature = 20;
    public int hydration = 100;
    public string[] items;
    public int gameSpeed = 1;
    public int hydrationDepletion = 1;

    private float timer;
    private float lastUpdate;
    private bool isGameOver = false;

    private void Awake()
    {
        this.timer = Time.time;
        this.lastUpdate = Time.time;
    }

    void Update()
    {
        this.timer += Time.deltaTime;
        if (this.timer - this.lastUpdate > this.gameSpeed)
        {
            Debug.LogFormat("sweat: {0}, hydration {1}, isGameOver {2}", this.sweat, this.hydration, this.isGameOver);
            this.GameTick();
        }
        if (this.IsGameEnding()) {
            this.GameOver();
        }
    }

    private void GameTick() {
        this.hydration -= this.hydrationDepletion;
        this.sweat -= this.GetSweatIncome();
    }

    private int GetSweatIncome() {
        // will use the items to calculate what the income is
        // Run on every game loop, but probably simpler than storing the income as a separate state
        return 1;
    }

    private bool IsGameEnding() {
        return this.hydration <= 0;
    }

    private void GameOver() {
        this.isGameOver = true;
        // Should destroy class/change scene or something here.
        Destroy(this);
    }

}