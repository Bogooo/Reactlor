using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Slider vv;
    public Toggle muted;
    public Toggle screen;


    public void Start()
    {

        float vol = PlayerPrefs.GetFloat("volume");
        if(vv != null)vv.value = vol;

        int ok = PlayerPrefs.GetInt("mute");
        if (ok == 1) muted.SetIsOnWithoutNotify(true);

        ok = PlayerPrefs.GetInt("full");
        if (ok == 1) screen.SetIsOnWithoutNotify(true);


    }

    public void SetVolume(float volume)
    {
            audiomixer.SetFloat("volume", Mathf.Log10(volume) * 20);
            PlayerPrefs.SetFloat("volume", volume);
    }


    public void fullScreen(bool isfull)
    {
        Screen.fullScreen = isfull;
        int ok;
        if (isfull) ok = 1;
        else ok = 0;
        PlayerPrefs.SetInt("full", ok);
    }

    public void mute(bool ismuted)
    {
        AudioListener.pause = ismuted;
        int ok;
        if (ismuted) ok = 1;
        else ok = 0;
        PlayerPrefs.SetInt("mute", ok);
    }

    public void Resetscore()
    {
        PlayerPrefs.SetInt("high", 0);
        PlayerPrefs.SetInt("curent", 0);
    }

}
