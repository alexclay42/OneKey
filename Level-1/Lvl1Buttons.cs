using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl1Buttons : MonoBehaviour
{
   public CanvasGroup canvas;

   public void UseKey()
    {
        // add in key pic and invalidate it across
        // unlock door
        Lvl1Dialogue.doorLocked = false;
        Door1.usedKey = true;
        VariableHolder.hasKey = false;
        canvas.alpha = 0f;

    }

    public void DonUseKey()
    {
        Lvl1Dialogue.doorLocked = false;
        Debug.Log(Lvl1Dialogue.doorLocked);
    }
}
