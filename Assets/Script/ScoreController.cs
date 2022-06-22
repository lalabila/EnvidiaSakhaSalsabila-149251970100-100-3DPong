using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI redScore, blueScore, yellowScore, purpleScore;
    public ScoreManager manager;
    private void Update()
    {
        redScore.text = manager.redScore.ToString();
        blueScore.text = manager.blueScore.ToString();
        yellowScore.text = manager.yellowScore.ToString();
        purpleScore.text = manager.purpleScore.ToString();
    }
}
