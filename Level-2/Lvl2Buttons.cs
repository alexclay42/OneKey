using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Buttons : MonoBehaviour
{
    public CanvasGroup canvas;
    public CanvasGroup key;
   
    public void useKey()
    {
        Door2.usedKey = true;
        VariableHolder.hasKey = false;
        canvas.alpha = 0f;
        key.alpha = 0f;
    }


    public void DontUse()
    {
        canvas.alpha = 0f;
    }
}
