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
    public SpriteRenderer apartmentSprite;
    public SpriteRenderer[] windowsSprites;
    private void Update()
    {
        windowsSprites[0].sprite = windowSpritesDataBase[windowOneID];
        windowsSprites[1].sprite = windowSpritesDataBase[windowTwoID];
    }
}
