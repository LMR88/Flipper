using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Audio;


public class ChoiceNewGame : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] bool menuOpen;
    [SerializeField] Image[] whichone;
    public AudioClip select; // Assign this in the Inspector
    private AudioSource audioSource;

    public void OpenCloseMenu()
    {
        Debug.Log("Open Close Menu");

        menuOpen = !menuOpen;

        menu.SetActive(menuOpen);
    }
    public void selectsound()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(select);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}