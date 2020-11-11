using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSpellBookUI : MonoBehaviour
{
    public GameObject spellBookUIPanel;
    bool isActive;

    public void OpenandClose()
    {
        if (isActive == false)
        {
            spellBookUIPanel.transform.gameObject.SetActive(true);
            isActive = true;
        }
        else 
        {
            spellBookUIPanel.transform.gameObject.SetActive(false);
            isActive = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
