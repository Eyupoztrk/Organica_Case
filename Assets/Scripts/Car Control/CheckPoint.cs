using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public CarControl carControl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("car"))
        {
            UIManager.instance.OpenGetInCarButton();
        }

        if (other.CompareTag("saller"))
        {
            UIManager.instance.OpenSallerPanel();
            GameManager.instance.SetSaller(other.gameObject);

        }

        if (other.CompareTag("playerGallery"))
        {
            GameManager.instance.ActivePlayerGallery();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("saller"))
        {
            UIManager.instance.CloseSallerPanel();
        }

        if (other.CompareTag("car"))
        {
            UIManager.instance.GetInCarButton.SetActive(false);
        }
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("ff");
        }
    }

    public void PlayerOut()
    {

        carControl.PlayerOutCar();
    }
}
