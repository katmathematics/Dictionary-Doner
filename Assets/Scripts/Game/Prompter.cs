using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Prompter : MonoBehaviour
{

    public TMP_Text promptOutput = null;

    private string currentPrompt = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        //SetCurrentPrompt("test prompt"); // Moved to Restaurant Manager
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentPrompt(string newPrompt, string themeKey = "null")
    {
        currentPrompt = newPrompt;
        DisplayPrompt(currentPrompt, themeKey);
    }

    private void DisplayPrompt(string prompt, string themeKey)
    {
        if (themeKey == "agent")
        {
            prompt = "Doner, " + prompt + " doner.";
        }
        else
        {
            prompt = "One " + prompt + " special bitte!";
        }

        promptOutput.text = prompt;
    }

}
