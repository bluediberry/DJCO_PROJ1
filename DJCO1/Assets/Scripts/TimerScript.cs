using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 100f;
    public float timeLeft;
    public GameObject timesUpText;


    static TimerScript _instance;

    void Awake()
    {
        //register this countdown instance:
        _instance = this;
    }

    public static void ModifyTimer(float byAmount)
    {
        _instance.timeLeft += byAmount;
    }


// Start is called before the first frame update
void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

