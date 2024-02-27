using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PlayerController : MonoBehaviour
{
    public SerialController serialController;
    public int playerHealth;
    public float playerSpeed;

    
     void Update()
     {
         if(Input.GetKeyDown(KeyCode.A))
         {
             serialController.SendSerialMessage("A");
         }
         if (Input.GetKeyDown(KeyCode.Z))
         {
             serialController.SendSerialMessage("Z");
         }
     }
    

   /* private void Update()
    {
        Debug.Log("Player Health" + playerHealth + " | Player Speed" + playerSpeed);

        if (Input.GetKeyDown(KeyCode.A))
        {
            serialController.SendSerialMessage("A");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            serialController.SendSerialMessage("Z");
        }
    }
   */
}