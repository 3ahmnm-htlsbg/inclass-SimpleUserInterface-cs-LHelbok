using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    public Text countOne;
    public int counter;
    
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
}
