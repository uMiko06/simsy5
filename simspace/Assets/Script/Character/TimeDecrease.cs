using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class TimeDecrease : MonoBehaviour
{

    public float maxSleep = 11f;
    public float currentSleep;
    public float sleepDecreaseRate = 1f;
    public Image sleepBar;
    public List <Image> sleepBarParts;

    public float maxFeed = 11f;
    public float currentFeed;
    public float feedDecreaseRate = 1f;
    public Image feedBar;
    public List <Image> feedBarParts;

    public float maxEntertainment = 11f;
    public float currentEntertainment;
    public float entertaimentDecreaseRate = 1f;
    public Image entertainmentBar;
    public List<Image> entertainmentBarParts;

    void Start()
    {
        currentSleep = maxSleep;
        currentFeed = maxFeed;
        currentEntertainment = maxEntertainment;
    }

    void Update()
    {
        currentSleep -= sleepDecreaseRate * Time.deltaTime;
        sleepBar.fillAmount = currentSleep / maxSleep;
        

        currentFeed -= feedDecreaseRate * Time.deltaTime;
        feedBar.fillAmount = currentFeed / maxFeed;
        

        currentEntertainment -= entertaimentDecreaseRate * Time.deltaTime;
        entertainmentBar.fillAmount = currentEntertainment / maxEntertainment;
        UpdateHud();
    }
     
    public void UpdateHud()
    {
        for (int i = 0; i < sleepBarParts.Count; i++)
        {
            if (i > currentSleep)
            {
                sleepBarParts[i].enabled = false; 
            }

            if (i > currentFeed)
            {
                feedBarParts[i].enabled = false;
            }

            if (i > currentEntertainment)
            {
                entertainmentBarParts[i].enabled = false;
            }
        }

        
    }

}

