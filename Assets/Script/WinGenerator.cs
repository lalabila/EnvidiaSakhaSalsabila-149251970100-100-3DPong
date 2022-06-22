using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGenerator : MonoBehaviour
{   
    [SerializeField] GameObject redText, blueText, yellowText, purpleText;
    void Update()
    {
    if(GoalController.red == true)
    {
        redText.SetActive(true);
    }
    if(GoalController.blue == true)
    {
        blueText.SetActive(true);
    }
    if(GoalController.yellow == true)
    {
        yellowText.SetActive(true);
    }
    if(GoalController.purple == true)
    {
        purpleText.SetActive(true);
    }
    }
}
