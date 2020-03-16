using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectible
{
    //every class implementing ICollectible must have this method as public:
    void OnCollected();
}