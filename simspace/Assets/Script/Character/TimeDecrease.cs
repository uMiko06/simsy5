using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeDecrease : MonoBehaviour
{

    public float maxSleep = 11f;
    public float currentSleep;
    public float sleepDecreaseRate = 1f;
    public Image sleepBar;

    public float maxFeed = 11f;
    public float currentFeed;
    public float feedDecreaseRate = 1f;
    public Image feedBar;

    public float maxEntertainment = 11f;
    public float currentEntertainment;
    public float entertaimentDecreaseRate = 1f;
    public Image entertainmentBar;

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
    }

}

