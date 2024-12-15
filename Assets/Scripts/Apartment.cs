using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apartment : MonoBehaviour
{
    public int windowOneID;
    public int windowTwoID;
    public int optionWindowOne;
    public int optionWindowTwo;
    public Sprite[] spriteDataBase;
    public Sprite[] windowSpritesDataBase;
    public Sprite[] giftsDataBase;
    public Sprite[] windwOptionSprites;
    public SpriteRenderer apartmentSprite;
    public SpriteRenderer[] windowsSprites;
    public SpriteRenderer[] windowOptions;
    private void Update()
    {
        windowsSprites[0].sprite = windowSpritesDataBase[windowOneID];
        windowsSprites[1].sprite = windowSpritesDataBase[windowTwoID];
        if(windowOneID == 0)
        {
            if(optionWindowOne == 0)
            {
                windowOptions[0].sprite = windwOptionSprites[0];
            }
            if (optionWindowOne == 1)
            {
                windowOptions[0].sprite = windwOptionSprites[1];
            }
        }
        if (windowOneID == 1)
        {
            if (optionWindowOne == 0)
            {
                windowOptions[0].sprite = windwOptionSprites[2];
            }
            if (optionWindowOne == 1)
            {
                windowOptions[0].sprite = windwOptionSprites[3];
            }
        }
        if (windowOneID == 2)
        {
            if (optionWindowOne == 0)
            {
                windowOptions[0].sprite = windwOptionSprites[4];
            }
            if (optionWindowOne == 1)
            {
                windowOptions[0].sprite = windwOptionSprites[5];
            }
        }
        if (windowTwoID == 0)
        {
            if (optionWindowTwo == 0)
            {
                windowOptions[1].sprite = windwOptionSprites[0];
            }
            if (optionWindowTwo == 1)
            {
                windowOptions[1].sprite = windwOptionSprites[1];
            }
        }
        if (windowTwoID == 1)
        {
            if (optionWindowTwo == 0)
            {
                windowOptions[1].sprite = windwOptionSprites[2];
            }
            if (optionWindowTwo == 1)
            {
                windowOptions[1].sprite = windwOptionSprites[3];
            }
        }
        if (windowTwoID == 2)
        {
            if (optionWindowTwo == 0)
            {
                windowOptions[1].sprite = windwOptionSprites[4];
            }
            if (optionWindowTwo == 1)
            {
                windowOptions[1].sprite = windwOptionSprites[5];
            }
        }
    }
}
