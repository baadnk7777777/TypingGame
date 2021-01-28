using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem particles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            particles.Play();
        

    }
}
