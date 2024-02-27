using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class InterpretArduino : MonoBehaviour
{

    public SerialController serialController;

    void OnMessageArrived(string msg)
    {
        Debug.Log(msg);
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
