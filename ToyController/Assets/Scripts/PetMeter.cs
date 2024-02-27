using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetMeter : MonoBehaviour
{
    public float startingHappiness = 100f;
    public float decreaseRate = 1f;
    public float decreaseInterval = 1f;
    public float increaseAmount = 10f;

    private float currentHappiness;
    private float timer;

    public Slider happinessSlider;

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
    }

    public void IncreaseHappiness()
    {
        currentHappiness += increaseAmount;
        currentHappiness = Mathf.Min(startingHappiness, currentHappiness);
    }
}
