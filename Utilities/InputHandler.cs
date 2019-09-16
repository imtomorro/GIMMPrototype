using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {

    public InputField inputText;
    public Text outputText;
    public Button textButton;
    public int avNum = 0;
    public int avAlph = 0;
	// Use this for initialization
	void Start () {
        outputText.text = "";
    }
    public void processText()
    {
        outputText.text = Utilities.ProcessText(inputText.text);
        string[] nums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        foreach (string num in nums)
        {
            if (inputText.text.Contains(num))
            {
                avNum = inputText.text.Length;
                string avNumText = avNum.ToString();
                outputText.text = avNumText;
            }
        }
        string[] alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        foreach (string alph in alpha)
        {
            if (inputText.text.Contains(alph))
            {
                inputText.text.Split(' ');
                avAlph = inputText.text.Length;
                string avAlphText = avAlph.ToString();
                outputText.text = avAlphText;
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
