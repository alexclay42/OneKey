using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public static bool isOpen = false;
    public static bool usedKey = false;

    private void OnTriggerEnter2D(Collider2D collision)

  //  private void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("Doir Hit");


        if (Puzzle1.puzzle1 == true && Puzzle1.puzzle2 == true && Puzzle1.puzzle3 == true)
        {
            Debug.Log("Puzzle Solve");
            SceneManager.LoadScene("Lvl2");
        }
        else if (usedKey == true)
        {
            Lvl1Dialogue.doorLocked = false;
            SceneManager.LoadScene("Lvl2");
            Debug.Log("Key Solve");
        }
      
    }
   
  
}
