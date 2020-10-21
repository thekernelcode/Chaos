using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int health;

    // Use this for initialization
    void Start()
    {
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
    }
}