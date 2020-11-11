using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //public GameObject spawnTestEnemy;

    public List<GameObject> spawnedUnits;

    // Start is called before the first frame update
    void Start()
    {
        spawnedUnits = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // SPAWN UNIT TEST TEXT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastSpell();
        }


        void CastSpell()
        {
            //GameObject go = Instantiate(spawnTestEnemy, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)), Quaternion.identity);

            //go.GetComponent<Unit>().SetHealth(Random.Range(0,5));
            //go.GetComponent<Unit>().GetHealth();      
            //spawnedUnits.Add(go);
        }
    }
}
