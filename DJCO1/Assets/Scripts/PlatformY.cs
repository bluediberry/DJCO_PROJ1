using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformY : MonoBehaviour
{

    float dirY, moveSpeed = 3f;
    bool moveUp = true;
    public float posYin;
    public float posYen;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > posYen)
            moveUp = false;
        if (transform.position.y < posYin)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }
}
