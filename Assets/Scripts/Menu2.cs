using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu2 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer MenuSound;

    [Header("UI Slider")]
    public Slider MenuSoundSlider;

    private void Start()
    {
        float defaultVolume = 0.5f; // 50% głośności

        // Ustawienie slidera
        if (MenuSoundSlider != null)
            MenuSoundSlider.value = defaultVolume;

        // Ustawienie głośności w mixerze
        if (MenuSound != null)
            MenuSound.SetFloat("MenuSound", Mathf.Log10(defaultVolume) * 20);
    }

    // Funkcja wywoływana przez slider
    public void SetGameMusic(float value)
    {
        if (MenuSound != null)
            MenuSound.SetFloat("MenuSound", Mathf.Log10(value) * 20);
    }
}


//GameMusicSettings
