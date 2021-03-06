﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFrontBehaviour : MonoBehaviour

{
    public Sprite death;
    public Sprite hermit;
    public Sprite lovers;
    public Sprite fool;
    private int spriteNumber;


    public int getSpriteNumber()
    {
        return spriteNumber;
    }

    public void setSprite(int number)
    {
        GetComponent<Image>().sprite = GetSprite(number);
        spriteNumber = number;
    }

    public Sprite GetSprite(int number)
    {
        switch (number)
        {
            case 0:
                return death;
            
            case 1:
                return hermit;
           
            case 2:
                return lovers;
             
            case 3:
                return fool;
               
            default:
                return death;
         
        }
    }
}