using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    public GameObject cover;
    public HingeJoint myHinge;
    void Start()
    {
        var myHinge = cover.GetComponent<HingeJoint>();

        myHinge.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenSesame()
    {
        myHinge.useMotor = true;
        Debug.Log("moto should be true ");
    }
}
