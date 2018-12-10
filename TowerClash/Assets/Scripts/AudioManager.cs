using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	public AudioMixer mixer;

	public string masterVolume = "Master";
	public string musicVolume = "Music";
	public string sfxVolume = "SFX";

    AudioSource musicthemes;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(this);
	}

	private void SetGroupVolume(string channelName, float volume)
	{
		float linearVolume = Mathf.Log(volume) * 20f;
		mixer.SetFloat(channelName, linearVolume);
	}

	public void SetMasterVolume(float volume)
	{
		SetGroupVolume(masterVolume, volume);
		PlayerPrefs.SetFloat(masterVolume, volume);
	}
	public void SetMusicVolume(float volume)
	{
		SetGroupVolume(musicVolume, volume);
        PlayerPrefs.SetFloat(musicVolume, volume);
    }

	public void SetSFXVolume(float volume)
	{
		SetGroupVolume(sfxVolume, volume);
        PlayerPrefs.SetFloat(sfxVolume, volume);
    }

}
