using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalController : MonoBehaviour
{
    public GameObject redWall, blueWall, yellowWall, purpleWall;
    public GameObject redPad, bluePad, yellowPad, purplePad;
    public static bool red = true,
        blue = true,
        yellow = true,
        purple = true;
    private int playerFailed;

    void Start() {
    playerFailed = 0;
    red = true;
    blue = true;
    yellow = true;
    purple = true;
    }   
    void Update() {
    if(playerFailed == 3)
    {
        if(red == true)
        {
            Debug.Log("Red win");
            GameOver();
        }
        else if(blue == true)
        {
            Debug.Log("blue win");
            GameOver();
        }
        else if(yellow == true) 
        {
            Debug.Log("ye win");
            GameOver();
        }
        else if(purple == true)
        {
            Debug.Log("pur win");
            GameOver();
        }
    }
}

    public void redGoalOff(){
        redWall.GetComponent<MeshCollider>().isTrigger = false;
        redWall.GetComponent<MeshCollider>().convex = false;
        redPad.GetComponent<MeshRenderer>().enabled = false;
        redPad.GetComponent<BoxCollider>().enabled = false;
        playerFailed += 1;
        red = false;
    }
    public void blueGoalOff(){
        blueWall.GetComponent<MeshCollider>().isTrigger = false;
        blueWall.GetComponent<MeshCollider>().convex = false;
        bluePad.GetComponent<MeshRenderer>().enabled = false;
        bluePad.GetComponent<BoxCollider>().enabled = false;
        playerFailed += 1;
        blue = false;
    }
    public void yellowGoalOff(){
        yellowWall.GetComponent<MeshCollider>().isTrigger = false;
        yellowWall.GetComponent<MeshCollider>().convex = false;
        yellowPad.GetComponent<MeshRenderer>().enabled = false;
        yellowPad.GetComponent<BoxCollider>().enabled = false;
        playerFailed += 1;
        yellow = false;
    }
    public void purpleGoalOff(){
        purpleWall.GetComponent<MeshCollider>().isTrigger = false;
        purpleWall.GetComponent<MeshCollider>().convex = false;
        purplePad.GetComponent<MeshRenderer>().enabled = false;
        purplePad.GetComponent<BoxCollider>().enabled = false;
        playerFailed += 1;
        purple = false;
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
