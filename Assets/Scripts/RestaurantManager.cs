using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestaurantManager : MonoBehaviour
{
    public WordBank wordBank = null;
    public Prompter prompter = null;
    public Typer typer = null;

    private Tuple<string, string, string> currentTask = new Tuple <string, string, string>("Hallo Welt", "general", "One \"Hello World\" special, bitte.");

    // Start is called before the first frame update
    void Start()
    {
        
        SetCurrentTask();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentTask() {
        currentTask = wordBank.GetTask();
        typer.SetCurrentWord(currentTask.Item1);
        prompter.SetCurrentPrompt(currentTask.Item3);
    }
}
