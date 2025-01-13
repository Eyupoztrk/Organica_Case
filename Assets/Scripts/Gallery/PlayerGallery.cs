using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGallery : MonoBehaviour
{
    public static PlayerGallery instance;

    private void Awake()
    {

        instance = this;
    }
    public Player player;
    public List<GameObject> Cars;
    public List<GameObject> AllCars;
    public int _carIndex;
    public Transform stand;


    private void Start()
    {
      //  OpenGallery();
    }

    public void OpenGallery()
    {
        //Cars = player.Cars;

        foreach (var item in player.Cars)
        {
            Cars.Add(Instantiate(item,stand.position,Quaternion.identity));
        }

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
