using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTracker : MonoBehaviour
{
    public static int cardsSelected = 0;
    public void Update()
    {
        if (SmuggleManager.isCardSelected == true )
        {
            cardsSelected++;
            //Debug.Log(cardsSelected);
        }
    }
}
