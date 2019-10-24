using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl1Dialogue : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Text text;
    Vector3 offScreen = new Vector3(2000, 2000);
    Vector3 button1On = new Vector3(150, 150);

    public CanvasGroup canvas;
    public static bool doorLocked = false;

    private void Start()
    {
        Hide();
    }

    public void Hide()
    {
        canvas.alpha = 0f;
        Debug.Log("Hid");
    }

    private void Update()
    {
        if (doorLocked == true)
        {
            canvas.alpha = 1f;

        }
        else if (doorLocked == false) {
            canvas.alpha = 0f;
        }

    }
}
