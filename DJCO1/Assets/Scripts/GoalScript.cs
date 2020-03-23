using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public void DeleteAll()
    {
        foreach (GameObject o in FindObjectsOfType<GameObject>())
        {
            Destroy(o);
        }
    }
    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "Coffee")
        {
            DeleteAll();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
