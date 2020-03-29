using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float maxTime = 20f;
    public float timeLeft;
    public bool clock = false;
    TextMeshProUGUI textMesh;
    public float finalTime;

    static TimeScript _instance;


    void Awake()
    {
        //register this countdown instance:
        _instance = this;
    }

    public static void ModifyTimer(float byAmount)
    {
        if (_instance.timeLeft < _instance.maxTime)
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
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = timeLeft.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        finalTime = timeLeft;

        if (!clock)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime * 0.7f;
                textMesh.text = timeLeft.ToString();
            }
        }
    }
}

