using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> Cars;
    public float money;

    public void BuyCar()
    {
        var car = Gallery.instance.saller.Cars[Gallery.instance._carIndex];
        if (money >= car.GetComponent<Car>().basePrice)
        {
            Cars.Add(car);
           
            money -= car.GetComponent<Car>().basePrice;
            Gallery.instance.playerMoneyText.text = money.ToString();
        }
        else
        {
            Debug.Log("not enough money");
        }

    }

    public void SellCar(GameObject car)
    {
        Cars.Remove(car);
    }

}
