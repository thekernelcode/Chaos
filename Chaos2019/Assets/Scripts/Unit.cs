using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int health;
    public int movement;
    public int defence;
    public int attack;

    private SpawnEnemy gameManager;

    // Use this for initialization
    void Start()
    {
        gameManager = FindObjectOfType<SpawnEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public int GetHealth()
    {
        Debug.Log(health + " Health returned");
        return health;
    }

    public void SetHealth(int h)
    {
        health = h;

        if (health <= 0)
        {
            Destroy(this.gameObject);
            gameManager.spawnedUnits.Remove(this.gameObject);

        }
    }
}