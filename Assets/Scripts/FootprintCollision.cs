using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootprintCollision : MonoBehaviour
{
    public static event Action OnCollideFootprint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        OnCollideFootprint();
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
}
