using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //MeshRenderer meshRenderer;

    void Start()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
    }

    //Collision other is into what we entered, like now, wall to player so other in this case would be player, thats why we can get it with tags
    // OnCollisionEnter is a unity callback, that's why we don't need to call it
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("wall was hit");
        // meshRenderer.material.color = Color.red;

        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }

}



// in inspector in unity there is components like transform, box collider, mesh renderer which we can access it here and change on required