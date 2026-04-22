using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu1 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer MenuMusic;

    [Header("UI Slider")]
    public Slider MenuMusicSlider;

    private void Start()
    {
        float defaultVolume = 0.5f; // 50% głośności

        // Ustawienie slidera
        if (MenuMusicSlider != null)
            MenuMusicSlider.value = defaultVolume;

        // Ustawienie głośności w mixerze
        if (MenuMusic != null)
            MenuMusic.SetFloat("MenuMusic", Mathf.Log10(defaultVolume) * 20);
    }

    // Funkcja wywoływana przez slider
    public void SetGameMusic(float value)
    {
        if (MenuMusic != null)
            MenuMusic.SetFloat("MenuMusic", Mathf.Log10(value) * 20);
    }
}


//GameMusicSettings
