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
    public Customers customers = null;
    public Typer typer = null;

    public TMP_Text wordOutput = null;
    public TMP_Text promptOutput = null;

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
        customers.SetCurrentTheme(currentTask.Item2);
        prompter.SetCurrentPrompt(currentTask.Item3, currentTask.Item2);
    }

    public void EndDay() {
        typer.enabled = false;
        wordOutput.enabled = false;
        customers.enabled = false;
    }
}
