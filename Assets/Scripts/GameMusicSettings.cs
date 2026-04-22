using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameMusicSettings : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer GameMusic;

    [Header("UI Slider")]
    public Slider GameMusicSlider;

    private void Start()
    {
        float defaultVolume = 0.5f; // 50% głośności

        // Ustawienie slidera
        if (GameMusicSlider != null)
            GameMusicSlider.value = defaultVolume;

        // Ustawienie głośności w mixerze
        if (GameMusic != null)
            GameMusic.SetFloat("GameMusic", Mathf.Log10(defaultVolume) * 20);
    }

    // Funkcja wywoływana przez slider
    public void SetGameMusic(float value)
    {
        if (GameMusic != null)
            GameMusic.SetFloat("GameMusic", Mathf.Log10(value) * 20);
    }
}


//GameMusicSettings
