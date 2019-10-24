using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puzzle1 : MonoBehaviour
{
    public float box1 = 1;
   // float box2 = 3;
    //float box3 = 2;
    public Image image1;
    //  public Image image2;
    // public Image image3;
    public static bool puzzle1 = false;
    public static bool puzzle2 = false;
    public static bool puzzle3 = false;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public void ValueChange()
    {
        Debug.Log("P1");

        if (box1.Equals(1))
        {
            box1 = 2;
        }
        else if (box1.Equals(2))
        {
            box1 = 3;
        }
        else if (box1.Equals(3))
        {
            box1 = 1;
        }
        ImageChange();
    }

    public void ImageChange()
    {
        if (box1.Equals(1))
        {
            image1.sprite = sprite1;
        }
        else if (box1.Equals(2))
        {
            image1.sprite = sprite2;
        }
        else if (box1.Equals(3))
        {
            image1.sprite = sprite3;
        }
    }

    public void CheckRightbox1()
    {
        if (box1.Equals(3))
        {
            puzzle1 = true;
            Debug.Log("box1true");
            Debug.Log(box1);
        }
        else
        {
            puzzle1 = false;
        }
    }

    public void CheckRightbox2()
    {
        if (box1.Equals(1))
        {
            puzzle2 = true;
            Debug.Log("2true");
        }
        else
        {
            puzzle2 = false;
        }
    }
    public void CheckRight3()
    {
        if (box1.Equals(2))
        {
            puzzle3 = true;
            Debug.Log("3true");
        }
        else
        {
            puzzle3 = false;
        }
    }
    private void Update()
    {
        CheckRight3();

    }


}
