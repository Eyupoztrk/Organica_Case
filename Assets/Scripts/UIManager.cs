using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }



    #region Saller UI

    public GameObject SallerPanel;

    public void OpenSallerPanel()
    {
        SallerPanel.SetActive(true);
    }

    public void CloseSallerPanel()
    {
        SallerPanel.SetActive(false);
    }




    #endregion



    #region Car UI

    public GameObject GetOutCarButton;
    public GameObject GetInCarButton;

    public void OpenGetOutCarButton()
    {
        GetOutCarButton.SetActive(true);
        GetInCarButton.SetActive(false);
    }

    public void OpenGetInCarButton()
    {
        GetOutCarButton.SetActive(false);
        GetInCarButton.SetActive(true);
    }




    #endregion
}
