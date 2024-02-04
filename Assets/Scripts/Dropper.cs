using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitingTime = 5f;
    // Caching technique storing frequently used data/info in memory, to easily access
    MeshRenderer meshRenderer;
    Rigidbody rb;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Time.time > waitingTime)
        {
            // turn of the component
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }

    }


}
