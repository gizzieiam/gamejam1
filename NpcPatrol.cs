using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcPatrol : MonoBehaviour
{
    public static float speed;
    public float timer;
    public Transform[] moveSpot;
    public float startWaitTime;
    private int randomSpot;
    private float waitTime;


    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpot.Length);
        timer = 0.0f;        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = Vector3.MoveTowards(transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);    

            if(Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f) 
            {
                if(waitTime <= 0)
                {
                    randomSpot = Random.Range(0, moveSpot.Length);
                    waitTime = startWaitTime;
                }
                else 
                {
                    waitTime -= Time.deltaTime;
                }
            }
        
    }
    void OnCollisionEnter(Collision col)
    {
        //
    }
}


