using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockCheck2 : MonoBehaviour
{
    public CanvasGroup canvasKey;
    public CanvasGroup noKey;
    public CanvasGroup key;

    private void Start()
    {
        canvasKey.alpha = 0f;
        noKey.alpha = 0f;

        if (VariableHolder.hasKey == false)
        {
            key.alpha = 0f;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((PuzzleCheck.inputCorrect == false) && Door2.usedKey == false){
            //view other canvas

    
    Debug.Log("Door Locked");
            if (VariableHolder.hasKey == true)
            {
                canvasKey.alpha = 1f;
            }
            else
            {
                noKey.alpha = 1f;
            }
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        noKey.alpha = 0f;  
    }
}
