using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    public Text countOne;
    public int counter;
    public InputField input;
    public Button textButton;
    public Text result;
    
    void Start()
    {
        counter = 0;
    }

    private int AddOne()
    {
        counter++;
        return counter;   
    }

    public void ShowCounter()
    {
            countOne.text = AddOne().ToString();
        
    }

    public void CopyText()
    {
        result.text = input.text;
    }
}
