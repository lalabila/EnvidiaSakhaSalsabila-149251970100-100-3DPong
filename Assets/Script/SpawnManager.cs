using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Vector3 speedSpawned, spawnPosition;
    public int maxBallAmount;   
    public int spawnInterval;
    private float timer;
    public GameObject ball;
    private List<GameObject> ballList;

      private void Start()
    {
        ballList = new List<GameObject>();
        GenerateBall();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateBall();
            timer -= spawnInterval;
        }
    }

    public void GenerateBall()
    {
        int spawnArea = Random.Range(1,5);
        if (spawnArea == 1)
        {
            GenerateBallSpawn(1);
        }
        if (spawnArea == 2)
        {
            GenerateBallSpawn(2);
        }
        if (spawnArea == 3)
        {
            GenerateBallSpawn(3);
        }
        if (spawnArea == 4)
        {
            GenerateBallSpawn(4);
        }   
    }
    
    public void GenerateBallSpawn(int spawnPoint)
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }
        //left down
        if(spawnPoint == 1)
        {
            speedSpawned = new Vector3(8, 0, 8);
            spawnPosition = new Vector3(11, 0.25f, -3);
            SpawnBall(speedSpawned, spawnPosition);
        }
        //right down
        if(spawnPoint == 2)
        {
            speedSpawned = new Vector3(-8, 0, 8);
            spawnPosition = new Vector3(18, 0.25f, -3);
            SpawnBall(speedSpawned, spawnPosition);
        }
        //left up
        if(spawnPoint == 3)
        {
            speedSpawned = new Vector3(8, 0, -8);
            spawnPosition = new Vector3(11, 0.25f, 4);
            SpawnBall(speedSpawned, spawnPosition);
        }
        if(spawnPoint == 4)
        {
            speedSpawned = new Vector3(-8, 0, -8);
            spawnPosition = new Vector3(18, 0.25f, 4);
            SpawnBall(speedSpawned, spawnPosition);
        }
    }

    private void SpawnBall(Vector3 speedSpawned, Vector3 spawnPoint)
    {
        GameObject ballSpawned = Instantiate(ball, new Vector3(spawnPosition.x, spawnPosition.y, spawnPosition.z), Quaternion.identity);
        ballSpawned.GetComponent<BallController>().speed = speedSpawned;
        ballSpawned.SetActive(true);
        ballList.Add(ballSpawned);
    }   
    // public void GenerateBall(Vector3 position)
    // {

    //     if (position.x < powerUpAreaMin.x ||
    //         position.x > powerUpAreaMax.x ||
    //         position.y < powerUpAreaMin.y ||
    //         position.y > powerUpAreaMax.y)
    //     {
    //         return;
    //     }

    //     int randomIndex = Random.Range(0, ballTemplateList.Count);

    //     GameObject ball = Instantiate(ballTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
    //     ball.SetActive(true);

    //     ballList.Add(ball);

    // }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }

    // public void RemoveAllPowerUp()
    // {
    //     while (powerUpList.Count > 0)
    //     {
    //         RemovePowerUp(powerUpList[0]);
    //     }
    // }
}
