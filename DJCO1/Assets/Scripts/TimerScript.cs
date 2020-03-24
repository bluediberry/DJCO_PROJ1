using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 50f;
    public float timeLeft;
    public bool clock = false;

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

    public static void ModifyClock()
    {
        _instance.clock = true;
    }

    public static void ModifyCoffee()
    {
        _instance.clock = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        //timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (!clock)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime * 0.7f;
                timerBar.fillAmount = timeLeft / maxTime;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        timerBar.fillAmount = timeLeft / maxTime;


    }

}

