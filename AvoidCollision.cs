using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NpcPatrol;

public class AvoidCollision : MonoBehaviour
{
    public GameObject player;

    void DetectObject()
    {
        if ((player.transform.position-this.transform.position).sqrMagnitude<3*3) 
        {
            print(true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        string label = collision.gameObject.tag;
        
        if (label == "Player" || label == "npc")
        {
            Debug.Log("Do something else here");
        }
    }

}
