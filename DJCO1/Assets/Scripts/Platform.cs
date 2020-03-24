using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    float dirX, moveSpeed = 3f;
    bool moveRight = true;
    public float posXin;
    public float posXen;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > posXen)
            moveRight = false;
        if (transform.position.x < posXin)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
