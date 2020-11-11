using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateSpellBook : MonoBehaviour
{
    private GameObject player;
    public Button spellButtonPrefab;
    public Transform myCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(player);

        foreach (GameObject spell in player.GetComponent<Movement>().availableSpells)
        {
            Debug.Log("Instantiating");
            Button myBB = Instantiate<Button>(spellButtonPrefab, myCanvas);

            //TODO Link up with selected spell info
        }
    }
}
