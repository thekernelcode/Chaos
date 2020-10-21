using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cop
{
    public class Tile : MonoBehaviour
    {
        //public Material originalMaterial;
        //public Material crimeInProgressMaterial;
        //public bool crimeInProgress = false;
                
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider otherCollider)
        {

            Debug.Log("Trigger");
            if (otherCollider.gameObject.tag == "Player")
            {

                Debug.Log("Player triggered me!");
                //Material m = GetComponent<Renderer>().material = originalMaterial;
                //transform.position = new Vector3(transform.position.x, 10, transform.position.z);
            }
        }

        /*public void CrimeInProgress()
        {
            
            int randomX = Random.Range(0, TilemapManager.instance.mapWidth);

            int randomY = Random.Range(0, TilemapManager.instance.mapHeight);

            Debug.Log("Crime in progress at " + randomX + ", " + randomY);

            GameObject go = TilemapManager.instance.GetGameObject(randomX, randomY);

            if (crimeInProgress == false)
            {
                go.GetComponent<Renderer>().material = crimeInProgressMaterial;

                crimeInProgress = true;

                if (go != null)
                {
                    go.transform.position = new Vector3(go.transform.position.x, 1, go.transform.position.z);

                }
                else
                {
                    Debug.Log("Didn't get a Gameobject back");
                }

            }
            else
            {
                Debug.Log("Crime already in progress here....do nothing");
            }

            
            TilemapManager.instance.crimeInProgressCooldown = 5f;
        }
        */

    }
}
