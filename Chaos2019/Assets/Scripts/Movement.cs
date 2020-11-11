using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Unit myStats;

    public GameObject attackTarget;

    public GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(-Vector3.forward);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            /* --- Currently picking first object from list of mobs, and then attacking --- */
            
            attackTarget = gameManager.GetComponent<SpawnEnemy>().spawnedUnits[0];

            int h = attackTarget.GetComponent<Unit>().health;

            int attackDamage = myStats.attack - attackTarget.GetComponent<Unit>().defence;

            attackTarget.GetComponent<Unit>().SetHealth(h - attackDamage);

        }


    }
}
