using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer GameSound;

    [Header("UI Slider")]
    public Slider GameSoundSlider;

    private void Start()
    {
        float defaultVolume = 0.5f; // 50% głośności

        // Ustawienie slidera
        if (GameSoundSlider != null)
            GameSoundSlider.value = defaultVolume;

        // Ustawienie głośności w mixerze
        if (GameSound != null)
            GameSound.SetFloat("GameSound", Mathf.Log10(defaultVolume) * 20);
    }

    // Funkcja wywoływana przez slider
    public void SetGameMusic(float value)
    {
        if (GameSound != null)
            GameSound.SetFloat("GameSound", Mathf.Log10(value) * 20);
    }
}
