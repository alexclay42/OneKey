using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dooor3 : MonoBehaviour
{
    public static bool usedKey = false;
    public static bool trust = false;
    public static bool take = false;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        Debug.Log("Door Hit");


        if (trust == true)
        {
            Debug.Log("Puzzle Solve");
            SceneManager.LoadScene("NeutralEnd");
        }
        else if (usedKey == true)
        {
            SceneManager.LoadScene("GoodEnd");
            Debug.Log("Key Solve");
        }
        else if (take == true)
        {
            SceneManager.LoadScene("BadEnd");
            Debug.Log("Take solve");
        }

    }
}
