using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
   public CanvasGroup hasKey;
   public CanvasGroup noKey;
    public CanvasGroup key;
    public CanvasGroup badKey;
    public CanvasGroup result;
    public static bool stolen = false;
    private void Start()
    {
        result.alpha = 0f;
         hasKey.alpha = 0f;
        noKey.alpha = 0f;
        badKey.alpha = 0f;
        if(VariableHolder.hasKey == false)
        {
            key.alpha = 0f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide npc");
        if (collision.name.Equals("Player"))
        {
            Debug.Log("Playerhit");
            if (VariableHolder.hasKey == true)
            {
                hasKey.alpha = 1f;
            }
            else
            {

                noKey.alpha = 1f;
            }
        }
    }

    private void Update()
    {
        if (stolen == true & gameObject.activeInHierarchy)
        {
            Destroy(gameObject);
        }
    }
}
