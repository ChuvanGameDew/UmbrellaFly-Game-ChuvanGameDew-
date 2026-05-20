using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LocalizationSystem : MonoBehaviour
{
    public static LocalizationSystem Instance;

    [Header("Dropdown")]
    public TMP_Dropdown languageDropdown;

    [Header("Texts")]
    public TextMeshProUGUI[] texts;
    public string[] keys;

    private string currentLanguage = "en";

    [System.Serializable]
    public class Item
    {
        public string key;
        public string en;
        public string pl;
        public string es;
        public string ru;
        public string de;
        public string fr;
        public string pt;
        public string uk;
    }

    [System.Serializable]
    public class Root
    {
        public List<Item> items;
    }

    private Dictionary<string, Item> data = new Dictionary<string, Item>();

    private void Awake()
    {
        Instance = this;
        LoadJSON();
    }

    private void Start()
    {
        languageDropdown.onValueChanged.AddListener(SetLanguage);
        SetLanguage(languageDropdown.value);
    }

    void LoadJSON()
    {
        TextAsset json = Resources.Load<TextAsset>("localization");

        Root root = JsonUtility.FromJson<Root>(json.text);

        foreach (var item in root.items)
        {
            data[item.key] = item;
        }
    }

    public void SetLanguage(int index)
    {
        switch (index)
        {
            case 0: currentLanguage = "en"; break;
            case 1: currentLanguage = "pl"; break;
            case 2: currentLanguage = "es"; break;
            case 3: currentLanguage = "ru"; break;
            case 4: currentLanguage = "de"; break;
            case 5: currentLanguage = "fr"; break;
            case 6: currentLanguage = "pt"; break;
            case 7: currentLanguage = "uk"; break;
        }

        UpdateTexts();
    }

    void UpdateTexts()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = Get(keys[i]);
        }
    }

    public string Get(string key)
    {
        if (!data.ContainsKey(key)) return key;

        Item item = data[key];

        return currentLanguage switch
        {
            "en" => item.en,
            "pl" => item.pl,
            "es" => item.es,
            "ru" => item.ru,
            "de" => item.de,
            "fr" => item.fr,
            "pt" => item.pt,
            "uk" => item.uk,
            _ => item.en
        };
    }
}