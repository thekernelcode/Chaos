using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject unit;

    public List<GameObject> spawnedUnits;

    // Start is called before the first frame update
    void Start()
    {
        spawnedUnits = new List<GameObject>();
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

        // SPAWN UNIT TEST TEXT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastSpell();
        }


        void CastSpell()
        {
            GameObject go = Instantiate(unit, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)), Quaternion.identity);

            go.GetComponent<Unit>().SetHealth(Random.Range(0,5));
            go.GetComponent<Unit>().GetHealth();      
            spawnedUnits.Add(go);
        }

    }
}
