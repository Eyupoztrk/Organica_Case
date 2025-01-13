using UnityEngine;

public class Car : MonoBehaviour
{
    public string modelName; 
    public float condition = 100f; 
    public float topSpeed; 
    public float basePrice; 

   
    public string InfoOfCar()
    {
        return $"Model: {modelName} Kondisyon: {condition} Hız: {topSpeed} km/h Fiyat: {basePrice}$";
    }
}
