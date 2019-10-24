using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPuzzle : MonoBehaviour
{
    public CanvasGroup canvas;
    public Image image;
    public Sprite sprite;

    private void Start()
    {
        canvas.alpha = 0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enter");
        canvas.alpha = 1f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        canvas.alpha = 0f;
        image.sprite = sprite;
    }
}
