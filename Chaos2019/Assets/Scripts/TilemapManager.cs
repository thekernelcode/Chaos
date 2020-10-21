using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cop
{
    public class TilemapManager : MonoBehaviour
    {

        public static TilemapManager instance;

        public int mapWidth = 10;
        public int mapHeight = 10;

        public Transform tileParent; // Create transform to put tiles in to keep inspector tidy

        public GameObject tilePrefab;
        Transform[,] tilePosition; // 2D Array of tiles

        //public Tile tile;

        public List<GameObject> instantiatedGameObjects;
        
        public float crimeInProgressCooldown = 5f;


        private void Awake()
        {
            instance = this;
        }


        // Start is called before the first frame update
        void Start()
        {
            tilePosition = new Transform[mapWidth, mapHeight];

            instantiatedGameObjects = new List<GameObject>();

            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    GameObject go = Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity, tileParent);
                    go.name = (x + " , " + y);
                    instantiatedGameObjects.Add(go);
                }
            }

            crimeInProgressCooldown = 5f;
        }

        // Update is called once per frame
        void Update()
        {
            /*crimeInProgressCooldown -= Time.deltaTime;

            if (crimeInProgressCooldown <= 0)
            {
                tilePrefab.GetComponent<Tile>().CrimeInProgress();
            }*/
        }


        public GameObject GetGameObject(int x, int y)
        {
            foreach (GameObject go in instantiatedGameObjects)
            {
                if (go.transform.position.x == x && go.transform.position.z == y)
                {
                    return go;
                }
            }
            return null;
        }
    }
}
