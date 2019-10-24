using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCheck1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( (Puzzle1.puzzle1 == false || Puzzle1.puzzle2 == false || Puzzle1.puzzle3 == false) && Door1.usedKey == false)
        {
            Lvl1Dialogue.doorLocked = true;
            Debug.Log("Locked");
        }
        else
        {
            Destroy(gameObject);
        }


    }
}
