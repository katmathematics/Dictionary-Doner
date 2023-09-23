using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Customers : MonoBehaviour
{

    public Image customer = null;

    public Sprite jamesYacht;
    public Sprite gilliganGuppy;
    public Sprite jennaEricson;
    public Sprite highEmpressMusya;

    private string currentTheme = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        //SetCurrentPrompt("test prompt"); // Moved to Restaurant Manager
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentTheme(string newTheme)
    {
        currentTheme = newTheme;
        DisplayCharacter(currentTheme);
    }

    private void DisplayCharacter(string theme)
    {
        if(theme == "agent")
        {
            customer.sprite = jamesYacht;
        }
        else if (theme == "business") {
            customer.sprite = gilliganGuppy;
        }
        else if (theme == "politics") {
            customer.sprite = highEmpressMusya;
        }
        else
        {
            customer.sprite = jennaEricson;
        }
    }

}
