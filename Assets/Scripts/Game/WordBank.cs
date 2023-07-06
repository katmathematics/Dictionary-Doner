using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using System.Linq;


public class WordBank : MonoBehaviour
{

    public RestaurantManager Mikey = null;

    private List<Tuple<string, string, string>> taskList = new List<Tuple<string, string, string>>
    {
        //Format: "word", "theme tag", "prompt text" 
        ("die Waffe", "agent", "gun").ToTuple(),
        ("das Gift", "agent", "poison").ToTuple(),
        ("der Hai", "agent", "shark").ToTuple(),
        ("das Gold", "else", "gold").ToTuple()
    };

    private Tuple<string, string, string> currentTask = new Tuple <string, string, string>("Hallo Welt", "general", "One \"Hello World\" special, bitte.");

    private void Awake()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\Dictionary Doner\\Assets\\Data Files\\Tasks.txt");
        var reader = new StreamReader(File.OpenRead(path));

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split('|');
            
            taskList.Add(Tuple.Create(values[0],values[1],values[2]));
        }
    }

    public Tuple<string, string, string> GetTask()
    {      
        if (taskList.Count > 0)
        {
            currentTask = taskList.Last();
            taskList.Remove(taskList.Last());
        }
        else
        {
            print("Test.5");
            Mikey.EndDay();
            currentTask = ("null", "dev", "That's a wrap!").ToTuple();
        }
        

        return currentTask; //Tuple.Create("Hallo Welt", "general", "One \"Hello World\" special, bitte.");
    }
    
}