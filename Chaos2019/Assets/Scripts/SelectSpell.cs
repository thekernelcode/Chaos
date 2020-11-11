using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSpell : MonoBehaviour
{
    //public GameObject gameManager;

    public GameObject player;

    public GameObject selectedSpell;

    private Button myButton;

    public GameObject selectedSpellImageGameObject;
    public GameObject selectedSpellTextGameObject;


    public void Start()
    {
        myButton = GetComponent<Button>();
        myButton.GetComponentInChildren<Text>().text ="No spell selected";

        player = GameObject.FindGameObjectWithTag("Player");
        //selectedSpellImageGameObject = GameObject.Find("Selected Spell Image");
        //Debug.Log(selectedSpellImageGameObject);
    }
  
    public void selectSpell()
    {
        Debug.Log("Attempting to load resources");
        selectedSpell = Resources.Load("Prefabs/GiantSpider") as GameObject;
        myButton.GetComponentInChildren<Text>().text = selectedSpell.name;
        myButton.GetComponent<Image>().sprite = selectedSpell.GetComponent<SpriteRenderer>().sprite;


        player.GetComponent<Movement>().selectedSpell = selectedSpell;
        selectedSpellImageGameObject.SetActive(true);
        selectedSpellImageGameObject.GetComponent<Image>().sprite = selectedSpell.GetComponent<SpriteRenderer>().sprite;

        selectedSpellTextGameObject.SetActive(true);
        selectedSpellTextGameObject.GetComponent<Text>().text = selectedSpellTextGameObject.GetComponent<Text>().text + selectedSpell.name;
    }

    
}
