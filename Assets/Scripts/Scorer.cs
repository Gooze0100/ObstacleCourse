using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            count++;
            Debug.Log($"You have bumped into sth this many times: {count}");
        }
    }
}
