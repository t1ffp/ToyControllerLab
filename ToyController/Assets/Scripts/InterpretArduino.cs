using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class InterpretArduino : MonoBehaviour
{

    public SerialController serialController;

    public PetMeter petmeter;

    public Animator bearHappy;

    private void Start()
    {
        bearHappy = gameObject.GetComponent<Animator>();
    }


    void OnMessageArrived(string msg)
    {
        Debug.Log(msg);

        petmeter.currentHappiness += 5;
        bearHappy.SetBool("isPlaying", true);
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}

