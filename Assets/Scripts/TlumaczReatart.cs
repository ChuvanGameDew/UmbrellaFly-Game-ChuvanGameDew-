using UnityEngine;
using TMPro;

public class TlumaczMenuRestart : MonoBehaviour
{
    public TMP_Dropdown LanguageDrop;

    // ===== PRZYCISKI =====
    public TextMeshProUGUI Menu;
    public TextMeshProUGUI Restart;

    public static int SelectedLanguage { get; private set; } = 0;

    // INNA NAZWA ZAPISU – NIE KOLIDUJE Z GŁÓWNYM TLUMACZEM
    private const string SAVE_KEY = "SelectedLanguage_MenuRestart";

    private void Awake()
    {
        SelectedLanguage = PlayerPrefs.GetInt(SAVE_KEY, 0);
    }

    private void Start()
    {
        if (LanguageDrop != null)
            LanguageDrop.value = SelectedLanguage;

        UpdateLanguage();
    }

    private void Update()
    {
        if (LanguageDrop == null) return;

        int current = LanguageDrop.value;

        if (current != SelectedLanguage)
        {
            SelectedLanguage = current;
            PlayerPrefs.SetInt(SAVE_KEY, SelectedLanguage);
            PlayerPrefs.Save();

            UpdateLanguage();
        }
    }

    private void UpdateLanguage()
    {
        int SelectLanguage = SelectedLanguage;

        // 🇬🇧 ENGLISH (0)
        if (SelectLanguage == 0)
        {
            Menu.text = "Menu";
            Restart.text = "Restart";
        }

        // 🇵🇱 POLSKI (1)
        if (SelectLanguage == 1)
        {
            Menu.text = "Menu";
            Restart.text = "Restart";
        }

        // 🇪🇸 ESPAÑOL (2)
        if (SelectLanguage == 2)
        {
            Menu.text = "Menú";
            Restart.text = "Reiniciar";
        }

        // 🇷🇺 РУССКИЙ (3)
        if (SelectLanguage == 3)
        {
            Menu.text = "Меню";
            Restart.text = "Перезапуск";
        }

        // 🇩🇪 DEUTSCH (4)
        if (SelectLanguage == 4)
        {
            Menu.text = "Menü";
            Restart.text = "Neustart";
        }

        // 🇫🇷 FRANÇAIS (5)
        if (SelectLanguage == 5)
        {
            Menu.text = "Menu";
            Restart.text = "Redémarrer";
        }

        // 🇧🇷 PORTUGUÊS (6)
        if (SelectLanguage == 6)
        {
            Menu.text = "Menu";
            Restart.text = "Reiniciar";
        }

        // 🇺🇦 УКРАЇНСЬКА (7)
        if (SelectLanguage == 7)
        {
            Menu.text = "Меню";
            Restart.text = "Перезапуск";
        }
    }
}
