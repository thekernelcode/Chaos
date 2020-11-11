using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Unit myStats;

    public GameObject target;
    public GameObject selectedSpell;

    public GameObject gameManager;


    public List<GameObject> spawnedUnits;

    public List<GameObject> availableSpells;

    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<Unit>();

        spawnedUnits = new List<GameObject>();

        //availableSpells = new List<GameObject>();
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

            //TODO  Attack
            
            Debug.LogAssertion("NOT IMPLEMENTED YET");
            target = gameManager.GetComponent<SpawnEnemy>().spawnedUnits[0];

            int h = target.GetComponent<Unit>().health;

            int attackDamage = myStats.attack - target.GetComponent<Unit>().defence;

            target.GetComponent<Unit>().SetHealth(h - attackDamage);

        }

        // SPAWN UNIT TEST TEXT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastSpell();
        }


        void CastSpell()
        {
            GameObject go = Instantiate(selectedSpell, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)), Quaternion.identity);

            go.GetComponent<SpriteRenderer>().enabled = false;
            go.GetComponent<Unit>().SetHealth(Random.Range(1,5)); //TODO Health values are hardcoded. Need to set max health and current health etc etc
            go.GetComponent<Unit>().GetHealth();      
            spawnedUnits.Add(go);
        }


    }
}
