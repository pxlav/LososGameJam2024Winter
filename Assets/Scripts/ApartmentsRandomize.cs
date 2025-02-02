using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentsRandomize : MonoBehaviour
{
    public Apartment[] apartments;
    public int apartmentsCounter;
    public bool canRandomize;
    private void Start()
    {
        canRandomize = true;
    }
    private void Update()
    {
        if(canRandomize == true)
        {
            for (int i = 0; i < apartments.Length; i++)
            {
                apartments[i].windowOneID = Random.Range(0, 3);
                apartments[i].windowTwoID = Random.Range(0, 3);
                apartments[i].optionWindowOne = Random.Range(0, 2);
                apartments[i].optionWindowTwo = Random.Range(0, 2);
                apartments[i].apartmentSprite.sprite = apartments[i].spriteDataBase[Random.Range(0, 6)];
                if (i < apartments.Length)
                {
                    canRandomize = false;
                }
            }
        }
    }
}
