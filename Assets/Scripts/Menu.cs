using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Android;
using UnityEngine.UI;
using System;

public class Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject mainMenu;
    public GameObject settingsMenu;

    SoundManager soundManager;

    private void Start() {
        soundManager = FindObjectOfType<SoundManager>();
        //resolutions = Screen.resolutions;
        //resDropdown.ClearOptions();
        //List<string> options = new List<string>();
        //int resindex = 0;
        //for (int i=0; i<resolutions.Length; i++)
        //{
        //    string option = resolutions[i].width+" x "+resolutions[i].height;
        //    options.Add(option);

        //    if (resolutions[i].height == Screen.currentResolution.height 
        //    && resolutions[i].width == Screen.currentResolution.width)
        //    {
        //        resindex = i;
        //    }
        //}
        //resDropdown.AddOptions(options);
        //resDropdown.value = resindex;
        //resDropdown.RefreshShownValue();

    }
    public void Play()
    {
        click();
        Debug.Log("LOADING");
        SceneManager.LoadSceneAsync(1);
    }
    public void Quit()
    {
        click();
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void SetVolume(float Volume)
    {
        Debug.Log(Volume);
        audioMixer.SetFloat("Volume",Volume); //AudioMixer - expose parameter and rename to "Volume"
    }

    public void settings()
    {
        click();
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void back()
    {
        click();
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void click()
    {
        soundManager.Play("click1");
    }

    





}
