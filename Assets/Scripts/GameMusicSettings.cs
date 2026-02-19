using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameMusicSettings : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer GameMusic;

    [Header("UI Slider")]
    public Slider GameMusicSlider;

    // 🔥 WSPÓLNA WARTOŚĆ (do użycia w innych skryptach)
    public static float GameMusicVolume { get; private set; } = 0.5f;

    private void Awake()
    {
        // 🔹 wczytanie zapisu (jeśli nie ma → 0.5)
        GameMusicVolume = PlayerPrefs.GetFloat("GameMusicVolume", 0.5f);
    }

    private void Start()
    {
        // ustawienie slidera
        if (GameMusicSlider != null)
            GameMusicSlider.value = GameMusicVolume;

        // ustawienie głośności w mixerze
        SetMixerVolume(GameMusicVolume);
    }

    // wywoływane przez slider
    public void SetGameMusic(float value)
    {
        GameMusicVolume = value;

        // zapis do PlayerPrefs
        PlayerPrefs.SetFloat("GameMusicVolume", value);
        PlayerPrefs.Save();

        SetMixerVolume(value);
    }

    private void SetMixerVolume(float value)
    {
        if (value <= 0.0001f)
            GameMusic.SetFloat("GameMusic", -80f);
        else
            GameMusic.SetFloat("GameMusic", Mathf.Log10(value) * 20);
    }
}
