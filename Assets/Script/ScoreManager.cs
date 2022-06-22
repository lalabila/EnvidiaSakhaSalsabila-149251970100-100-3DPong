using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int redScore, blueScore, yellowScore, purpleScore;
    public int maxScore;
    public GoalController manager;
    // Start is called before the first frame update
    public void AddRedScore(int increment)
    {
        redScore += increment;
        if (redScore == maxScore)
        {
            manager.redGoalOff();
        }
    }

    public void AddBlueScore(int increment)
    {
        blueScore += increment;

        if (blueScore == maxScore)
        {
            manager.blueGoalOff();
        }
    }
    public void AddYellowScore(int increment)
    {
        yellowScore += increment;

        if (yellowScore == maxScore)
        {
            manager.yellowGoalOff();
        }
    }

    public void AddPurpleScore(int increment)
    {
        purpleScore += increment;

        if (purpleScore == maxScore)
        {
            manager.purpleGoalOff();
        }
    }
}
