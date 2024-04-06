using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //public string name;
    public AudioClip audioClip;
    public bool playOnAwake;
    public bool loop;
    public float volume;
    public float spatialBlend;
}
