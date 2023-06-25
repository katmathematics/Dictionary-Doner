using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Typer : MonoBehaviour
{
    public RestaurantManager Mikey = null;
    public TMP_Text wordOutput = null;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    private List<string> validCharacters = new List<string>()
    {
        "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
        "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
    };
    
    // Start is called before the first frame update
    private void Start()
    {
        //SetCurrentWord("test"); // Moved to Restaurant Manager
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();   
    }

    public void SetCurrentWord(string newWord)
    {
        currentWord = newWord;
        SetRemainingWord(string.Empty);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;
            
            if (keysPressed.Length == 1) {
                if (validCharacters.Contains(keysPressed))
                {
                    EnterLetter(keysPressed);
                }
                else if (Input.GetKey(KeyCode.Space))
                {
                    EnterLetter(" ");
                }
                else if (Input.inputString == "\b")
                {
                    RemoveLetter();
                }
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
       
        AddLetter(typedLetter);

        if(IsWordComplete())
        {
            Mikey.SetCurrentTask();
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void AddLetter(string letter)
    {
        string newString = remainingWord + letter;
        SetRemainingWord(newString);
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(remainingWord.Length - 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return remainingWord == currentWord;  
    }
}
