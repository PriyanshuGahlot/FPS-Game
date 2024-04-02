using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<Sound> Sounds;
    List<AudioSource> sources;

    private void Start()
    {
        sources = new List<AudioSource>();
        foreach(Sound sound in Sounds)
        {
            AudioSource source = gameObject.AddComponent<AudioSource>();
            source.clip = sound.audioClip;
            source.playOnAwake = sound.playOnAwake;
            source.loop = sound.loop;
            source.volume = sound.volume;
            source.spatialBlend = sound.spatialBlend;
            sources.Add(source);
        }
    }

    public void Play(string name)
    {
        foreach (AudioSource source in sources)
        {
            if (source.clip.name == name)
            {
                source.Play();
            }
        }
    }

    public void Stop(string name)
    {
        foreach (AudioSource source in sources)
        {
            if (source.clip.name == name)
            {
                source.Stop();
            }
        }
    }

}
