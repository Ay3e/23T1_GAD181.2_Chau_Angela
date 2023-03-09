using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeclaringTracker : MonoBehaviour
{
    [SerializeField] Text fishButton;
    [SerializeField] Text coconutButton;
    private void Update()
    {
        fishButton.text = SmuggleManager.cardsClicked + " Fish";
        coconutButton.text = SmuggleManager.cardsClicked + " Coconuts";
    }
}
