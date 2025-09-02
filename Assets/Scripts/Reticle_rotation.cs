using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle_rotation : MonoBehaviour
{   
    public float rotationSpeed = 200f; // velocidade de rotação em graus por segundo


       void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
     } 
}
