using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Collectible object
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class CollectibleObject : MonoBehaviour, ICollectible//<look it's implementing ICollectible
{
    /// <summary>
    /// Timer delta on collected
    /// </summary>
    public float timerDelta = 30f;

    public AudioSource audioSource;

    /// <summary>
    /// Implementation code for intereface ICollectible's "OnCollected" method
    /// </summary>
    public void OnCollected()
    {
        
        audioSource.Play();
        
        if (gameObject.tag == "Goal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        if (gameObject.tag == "Clock")
        {
            TimerScript.ModifyClock();
        }

        if (gameObject.tag == "Coffee")
        {
            TimerScript.ModifyCoffee();
        }

        //modify timer:
        TimerScript.ModifyTimer(timerDelta);

        //disable this object:
        gameObject.SetActive(false);

    }
}