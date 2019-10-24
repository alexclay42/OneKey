using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl3Buttons : MonoBehaviour
{
    public CanvasGroup hasKey;
    public CanvasGroup noKey;
    public CanvasGroup resultText;
    public CanvasGroup key;
    public CanvasGroup badKey;
    public Image result;
    // public Image imageNeutral;
    // public Image imageBad;
    public Sprite good;
    public Sprite bad;
    public Sprite ok;

    public void Trust()
    {
        Dooor3.trust = true;
        Debug.Log("trust");
        hasKey.alpha = 0f;
        noKey.alpha = 0f;
        resultText.alpha = 1f;
        result.sprite = good;
    }

    public void UseOwn()
    {
        Dooor3.usedKey = true;
        Debug.Log("use key");
        hasKey.alpha = 0f;
        key.alpha = 0f;
        resultText.alpha = 1f;
        result.sprite = ok;

    }

    public void TakeKey()
    {
        NPC.stolen = true;
        Dooor3.take = true;
        Debug.Log("take");
        hasKey.alpha = 0f;
        noKey.alpha = 0f;
        resultText.alpha = 1f;
        badKey.alpha = 1f;
        result.sprite = bad;


    }
}
