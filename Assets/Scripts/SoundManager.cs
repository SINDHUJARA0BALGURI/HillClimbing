using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Slider slider;
    public static SoundManager instance;
    AudioSource BackGroundAudio;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

    }
    

    public void Start()
    {
        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 1);
            Load();
        }
        else
        {
            Load();
        }

        BackGroundAudio = GetComponent<AudioSource>();
        BackGroundAudio.Play();
    }
    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        Save();
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
    }
    private void Load()
    {
       AudioListener.volume= PlayerPrefs.GetFloat("Volume");
    }
}