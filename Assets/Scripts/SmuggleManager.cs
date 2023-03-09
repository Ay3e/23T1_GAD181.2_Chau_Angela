using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class SmuggleManager : MonoBehaviour
{
    public GameObject cards;
    [SerializeField] private GameObject confirmGoodsButton;
    [SerializeField] private GameObject confirmGoodsText;
    public static bool isCardSelected;
    public static int cardsClicked;

    private void Start()
    {
        //Disable Button to Confirm Loot
        confirmGoodsButton.SetActive(false);
        //Disable Text to Confirm Goods
        confirmGoodsText.SetActive(false);
        //No cards are selected at the start
        isCardSelected = false;
        cardsClicked = 0;
    }
    private void Update()
    {
        if (cardsClicked > 0)
        {
            activateButtonToConfirm();
        }
        else
        {
            disableButtonToConfirm();
        }
    }

    void OnMouseDown()
    {
        cardsClicked++;
        isCardSelected = true;
        Destroy(cards);
        Debug.Log("hi");
        Debug.Log(cardsClicked);
    }

    void activateButtonToConfirm()
    {
        confirmGoodsButton.SetActive(true);
        confirmGoodsText.SetActive(true);
    }

    void disableButtonToConfirm()
    {
        confirmGoodsButton.SetActive(false);
        confirmGoodsText.SetActive(false);
    }
    
}
