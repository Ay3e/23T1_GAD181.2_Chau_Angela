using AngelaChau;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainCheckIn : MonoBehaviour
{
    [SerializeField] private Text goodNumberAndgoodIDText;
    private void Update()
    {
        if(SceneLoader.goodID == 0)
        {
            goodNumberAndgoodIDText.text = SmuggleManager.cardsClicked + " Fish";
        }
        if (SceneLoader.goodID == 1)
        {
            goodNumberAndgoodIDText.text = SmuggleManager.cardsClicked + " Coconuts";
        }
    }
}
