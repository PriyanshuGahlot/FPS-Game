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
    public Dropdown resDropdown;
    Resolution[] resolutions;

    private void Start() {
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();
        List<string> options = new List<string>();
        int resindex = 0;
        for (int i=0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width+" x "+resolutions[i].height;
            options.Add(option);

            if (resolutions[i].height == Screen.currentResolution.height 
            && resolutions[i].width == Screen.currentResolution.width)
            {
                resindex = i;
            }
        }
        resDropdown.AddOptions(options);
        resDropdown.value = resindex;
        resDropdown.RefreshShownValue();

    }
    public void Play()
    {
        Debug.Log("LOADING");
        SceneManager.LoadSceneAsync(1);
    }
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void SetVolume(float Volume)
    {
        Debug.Log(Volume);
        audioMixer.SetFloat("Volume",Volume); //AudioMixer - expose parameter and rename to "Volume"
    }

    // public void Quality (int Quality)
    // {
    //     Debug.Log(Quality);
    //     QualitySettings.SetQualityLevel(Quality+1);
    // }

    // public void SetFullscreen (bool isFullscreen)
    // {
    //     Debug.Log("Fullscreen :"+isFullscreen);
    //     Screen.fullScreen = isFullscreen;
    // }

    public void Click()
    {
        Debug.Log("CLICKED");
    }





}
