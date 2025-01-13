using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public RCC_CarControllerV3 CarController;
    public GameObject CarCamera;
    public GameObject Player;
    public GameObject PlayerCar;
    public GameObject PlayerCamera;




    public void PlayerInCar()
    {
        StartEngine();
        EnableControl(true);
        Player.SetActive(false);
        CarCamera.SetActive(true);
        PlayerCamera.SetActive(false);

        UIManager.instance.OpenGetOutCarButton();
    }

    public void PlayerOutCar()
    {
        StopEngine();
        EnableControl(false);
        Player.SetActive(true);
        Player.transform.position = PlayerCar.transform.position + Vector3.one * 2;
        CarCamera.SetActive(false);
        PlayerCamera.SetActive(true);

        UIManager.instance.GetInCarButton.SetActive(false);
        UIManager.instance.GetOutCarButton.SetActive(false);
    }

    private void StartEngine()
    {
        CarController.StartEngine();
    }
    private void StopEngine()
    {
        CarController.KillEngine();
    }

    private void EnableControl(bool status)
    {
        CarController.canControl = status;
    }
}
