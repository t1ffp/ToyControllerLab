using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class PetMeter : MonoBehaviour
{
    public float startingHappiness = 100f;
    public float decreaseRate = 20f;
    public float decreaseInterval = 1f;
    public float increaseAmount = 10f;

    public float currentHappiness;
    private float timer;

    public Slider happinessSlider;

    public SerialController serialcontroller;

    void Start()
    {
        currentHappiness = startingHappiness;
        timer = decreaseInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            DecreaseHappiness();
            timer = decreaseInterval;
        }

        happinessSlider.value = currentHappiness / startingHappiness;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseHappiness();
        }


    }

    void DecreaseHappiness()
    {
        currentHappiness -= decreaseRate;
        currentHappiness = Mathf.Max(0, currentHappiness);

        //serialcontroller.SendSerialMessage(currentHappiness.ToString());

        if(currentHappiness < 50)
        {
            serialcontroller.SendSerialMessage("A");
        }
        else if(currentHappiness > 50)
        {
            serialcontroller.SendSerialMessage("Z");
        }
    }

    public void IncreaseHappiness()
    {
        currentHappiness += increaseAmount;
        currentHappiness = Mathf.Min(startingHappiness, currentHappiness);
    }
}
