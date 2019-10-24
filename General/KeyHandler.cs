using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{
   public CanvasGroup key;

    // Update is called once per frame
    void Update()
    {
      if (VariableHolder.hasKey == false)
        {
            key.alpha = 0f;
        }
    }
}
