using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer GameSound;

    [Header("UI Slider")]
    public Slider GameSoundSlider;

    // 🔥 WSPÓLNA WARTOŚĆ (do użycia w innych skryptach)
    public static float GameSoundVolume { get; private set; } = 0.5f;

    private void Awake()
    {
        // 🔹 ładowanie zapisu (jeśli nie ma → 0.5)
        GameSoundVolume = PlayerPrefs.GetFloat("GameSoundVolume", 0.5f);
    }

    private void Start()
    {
        GameSoundSlider.value = GameSoundVolume;
        SetMixerVolume(GameSoundVolume);
    }

    // Wywoływane przez slider
    public void SetGameMusic(float value)
    {
        GameSoundVolume = value;

        PlayerPrefs.SetFloat("GameSoundVolume", value);
        PlayerPrefs.Save();

        SetMixerVolume(value);
    }

    private void SetMixerVolume(float value)
    {
        if (value <= 0.0001f)
            GameSound.SetFloat("GameSound", -80f);
        else
            GameSound.SetFloat("GameSound", Mathf.Log10(value) * 20);
    }
}
