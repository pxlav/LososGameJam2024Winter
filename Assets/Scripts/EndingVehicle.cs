using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingVehicle : MonoBehaviour
{
    public Ending ending;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ending.isVehicle = true;
    }
}
