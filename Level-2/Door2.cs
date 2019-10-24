using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door2 : MonoBehaviour
{
    public static bool usedKey = false;
    private void OnTriggerEnter2D(Collider2D collision)

    //  private void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("Door Hit");


        if (PuzzleCheck.inputCorrect == true)
        {
            Debug.Log("Puzzle Solve");
            SceneManager.LoadScene("Lvl3");
        }
        else if (usedKey == true)
        {
            SceneManager.LoadScene("Lvl3");
            Debug.Log("Key Solve");
        }

    }
}
