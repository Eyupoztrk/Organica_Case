using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject playerCam;
    public GameObject carCam;
    public GameObject galleryCam;



    #region Saller
    public GameObject gallery;
    public void SetSaller(GameObject saller)
    {
        Gallery.instance.saller = saller.GetComponent<Saller>();
        Gallery.instance.OpenGallery();
    }

    public void ActiveGallery()
    {
        UIManager.instance.CloseSallerPanel();
        gallery.SetActive(true);

        galleryCam.SetActive(true);
        playerCam.SetActive(false);
        carCam.SetActive(false);
        PlayerGalleryCam.SetActive(false);
    }

    public void CloseGallery()
    {
        gallery.SetActive(false);

        playerCam.SetActive(true);
        carCam.SetActive(false);
        galleryCam.SetActive(false);
        PlayerGalleryCam.SetActive(false);
    }

    #endregion


    #region Player Gallery
    public GameObject PlayerGalleryCanvas;
    public GameObject PlayerGalleryCam;

    public void ActivePlayerGallery()
    {
        PlayerGalleryCanvas.SetActive(true);
        PlayerGallery.instance.OpenGallery();

        PlayerGalleryCam.SetActive(true);
        playerCam.SetActive(false);
        carCam.SetActive(false);
        galleryCam.SetActive(false);

    }

    public void ClosePlayerGallery()
    {
        PlayerGalleryCanvas.SetActive(false);

        playerCam.SetActive(true);
        carCam.SetActive(false);
        galleryCam.SetActive(false);
        PlayerGalleryCam.SetActive(false);
    }

    #endregion
}
