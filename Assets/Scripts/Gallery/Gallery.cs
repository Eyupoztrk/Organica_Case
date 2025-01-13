using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gallery : MonoBehaviour
{
    public static Gallery instance;

    private void Awake()
    {

        instance = this;
    }

    public Saller saller;
    public Player player;
    private List<GameObject> Cars;
    public List<GameObject> AllCars;
    public int _carIndex;
    public TextMeshProUGUI carInfoText;
    public TextMeshProUGUI playerMoneyText;

    private void Start()
    {
        OpenGallery();
    }

    public void OpenGallery()
    {
        playerMoneyText.text = player.money.ToString();
        Cars = saller.Cars;

        foreach (var item in AllCars)
        {
            item.SetActive(false);
        }
        
        _carIndex = 0;
        ShowCars(_carIndex);
        _carIndex++;
    }

    

    public void ShowCars(int index)
    {
        for (int i = 0; i < Cars.Count; i++)
        {
            if (i == index)
            {
                Cars[i].gameObject.SetActive(true);
                carInfoText.text = Cars[i].GetComponent<Car>().InfoOfCar();
            }
            else
            {
                Cars[i].gameObject.SetActive(false);
            }
        }
    }


    public void SelectCar(int buttonIndex)
    {
        if (buttonIndex == 1) // right
        {
            if (_carIndex < Cars.Count - 1)
                ShowCars(++_carIndex);
        }

        if (buttonIndex == -1)  // left
        {
            if (_carIndex > 0)
                ShowCars(--_carIndex);
        }
    }
}
