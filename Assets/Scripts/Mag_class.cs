using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mag_class : MonoBehaviour
{
    public Material Clear;
    public Material Mirror;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetClear()
    {
        GetComponent<Renderer>().material = Clear;
    }
    
    public void SetMirror()
    {
        GetComponent<Renderer>().material = Mirror;
    }
}
