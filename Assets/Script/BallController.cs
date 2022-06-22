using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Collider redGoal, blueGoal, yellowGoal, purpleGoal;
    public float maxSpeed = 10.0f;
    private Rigidbody rig;
    public ScoreManager managerScore;
    public SpawnManager manager;
        
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Paddle" || other.gameObject.tag == "BallSpawner")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                Debug.Log("OK");
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
         if (collision == redGoal)
        {
            managerScore.AddRedScore(1);
            manager.RemoveBall(gameObject);
        }
        if (collision == blueGoal)
        {
            managerScore.AddBlueScore(1);
            manager.RemoveBall(gameObject);
        }
        if (collision == yellowGoal)
        {
            managerScore.AddYellowScore(1);
            manager.RemoveBall(gameObject);
        }
        if (collision == purpleGoal)
        {
             managerScore.AddPurpleScore(1);
             manager.RemoveBall(gameObject);
        }
    }
}
