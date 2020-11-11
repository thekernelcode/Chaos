using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSpell : MonoBehaviour
{
    //public GameObject gameManager;

    public GameObject selectedSpell;

    private Button myButton;

    public void Start()
    {
        myButton = GetComponent<Button>();
        myButton.GetComponentInChildren<Text>().text ="No spell selected";
    }
  
    public void selectSpell()
    {
        Debug.Log("Attempting to load resources");
        selectedSpell = Resources.Load("Prefabs/GiantSpider") as GameObject;
        myButton.GetComponentInChildren<Text>().text = selectedSpell.name;
        myButton.GetComponent<Image>().sprite = selectedSpell.GetComponent<SpriteRenderer>().sprite;
    }

    
}
