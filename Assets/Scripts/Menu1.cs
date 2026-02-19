using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu1 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer MenuMusic;

    [Header("UI Slider")]
    public Slider MenuMusicSlider;

    // 🔥 WSPÓLNA WŁAŚCIWOŚĆ
    public static float MenuMusicVolume { get; private set; } = 0.5f;

    private const string SAVE_KEY = "MenuMusicVolume";

    private void Awake()
    {
        // wczytanie zapisu
        MenuMusicVolume = PlayerPrefs.GetFloat(SAVE_KEY, 0.5f);
    }

    private void Start()
    {
        MenuMusicSlider.value = MenuMusicVolume;
        SetMixerVolume(MenuMusicVolume);
    }

    public void SetGameMusic(float value)
    {
        MenuMusicVolume = value;

        PlayerPrefs.SetFloat(SAVE_KEY, value);
        PlayerPrefs.Save();

        SetMixerVolume(value);
    }

    private void SetMixerVolume(float value)
    {
        if (value <= 0.0001f)
            MenuMusic.SetFloat("MenuMusic", -80f);
        else
            MenuMusic.SetFloat("MenuMusic", Mathf.Log10(value) * 20);
    }
}
