using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu2 : MonoBehaviour
{
    [Header("Audio Mixer")]
    public AudioMixer MenuSound;

    [Header("UI Slider")]
    public Slider MenuSoundSlider;

    // 🔥 WSPÓLNA WARTOŚĆ (do użycia w innych skryptach)
    public static float MenuSoundVolume { get; private set; } = 0.5f;

    private void Awake()
    {
        // 🔹 ładowanie zapisu (jeśli nie ma → 0.5)
        MenuSoundVolume = PlayerPrefs.GetFloat("MenuSoundVolume", 0.5f);
    }

    private void Start()
    {
        MenuSoundSlider.value = MenuSoundVolume;
        SetMixerVolume(MenuSoundVolume);
    }

    // Wywoływane przez slider
    public void SetGameMusic(float value)
    {
        MenuSoundVolume = value;

        PlayerPrefs.SetFloat("MenuSoundVolume", value);
        PlayerPrefs.Save();

        SetMixerVolume(value);
    }

    private void SetMixerVolume(float value)
    {
        if (value <= 0.0001f)
            MenuSound.SetFloat("MenuSound", -80f);
        else
            MenuSound.SetFloat("MenuSound", Mathf.Log10(value) * 20);
    }
}
