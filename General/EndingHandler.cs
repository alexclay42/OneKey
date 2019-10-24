﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingHandler : MonoBehaviour
{
    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;

    private void Start()
    {
        if(VariableHolder.hasKey == true)
        {
            image.sprite = sprite1;
        }
        else
        {
            image.sprite = sprite2;
        }
    }



}
