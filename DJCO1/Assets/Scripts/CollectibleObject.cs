using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Collectible object
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class CollectibleObject : MonoBehaviour, ICollectible//<look it's implementing ICollectible
{
    /// <summary>
    /// Timer delta on collected
    /// </summary>
    public float timerDelta = 10f;

    /// <summary>
    /// Implementation code for intereface ICollectible's "OnCollected" method
    /// </summary>
    public void OnCollected()
    {
        //modify timer:
        TimerScript.ModifyTimer(timerDelta);

        //disable this object:
        gameObject.SetActive(false);
    }
}