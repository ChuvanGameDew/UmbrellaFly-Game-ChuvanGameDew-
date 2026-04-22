using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tlumacz : MonoBehaviour
{
    // Dropdown
    public TMP_Dropdown LanguageDrop;
    // Menu
    public TextMeshProUGUI Play;
    public TextMeshProUGUI Settings;
    public TextMeshProUGUI Exit;
    // Settings
    public TextMeshProUGUI Game;
    public TextMeshProUGUI Graphics;
    public TextMeshProUGUI Volume;
    public TextMeshProUGUI Controls;
    public TextMeshProUGUI Language;

    private void Start() {
       
    }
    
    void Update()
    {
        int SelectLanguage = LanguageDrop.value;

        //English
        if (SelectLanguage == 0)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 110;
            PrzyciskRaycast.zmiennafontsize.prosto = 120;
            Play.text = "Play";
            Settings.text = "Settings";
            Exit.text = "Exit";
            Game.text = "Game";
            Graphics.text = "Graphics";
            Volume.text = "Volume";
            Controls.text = "Controls";
            Language.text = "Language";
        }

        //Polski
        if (SelectLanguage == 1)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 110;
            PrzyciskRaycast.zmiennafontsize.prosto = 120;
            Play.text = "Graj";
            Settings.text = "Ustawienia";
            Exit.text = "Wyjście";
            Game.text = "Gra";
            Graphics.text = "Grafika";
            Volume.text = "Głośność";
            Controls.text = "Sterowanie";
            Language.text = "Język";
        }
        //Español
        if (SelectLanguage == 2)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 110;
            PrzyciskRaycast.zmiennafontsize.prosto = 120;
            Play.text = "Jugar";
            Settings.text = "Ajustes";
            Exit.text = "Salir";
            Game.text = "Juego";
            Graphics.text = "Gráficos";
            Volume.text = "Volumen";
            Controls.text = "Controles";
            Language.text = "Idioma";
        }
        //Русский
        if (SelectLanguage == 3)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 93;
            PrzyciskRaycast.zmiennafontsize.prosto = 100;
            Controls.fontSize = 48;
            Play.text = "Играть";
            Settings.text = "Настройки";
            Exit.text = "Выход";
            Game.text = "Игра";
            Graphics.text = "Графика";
            Volume.text = "Громкость";
            Controls.text = "Управление";
            Language.text = "Язык";
        }
        else
        {
           Controls.fontSize = 50; 
        }
        
        //Deutsch
        if (SelectLanguage == 4)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 87;
            PrzyciskRaycast.zmiennafontsize.prosto = 93;
            Play.text = "Spielen";
            Settings.text = "Einstellungen";
            Exit.text = "Beenden";
            Game.text = "Spiel";
            Graphics.text = "Grafik";
            Volume.text = "Lautstärke";
            Controls.text = "Steuerung";
            Language.text = "Sprache";
        }
       
        //Français
        if (SelectLanguage == 5)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 93;
            PrzyciskRaycast.zmiennafontsize.prosto = 100;
            Play.text = "Jouer";
            Settings.text = "Paramètres";
            Exit.text = "Quitter";
            Game.text = "Jeu";
            Graphics.text = "Graphismes";
            Volume.text = "Volume";
            Controls.text = "Commandes";
            Language.text = "Langue";
        }
      
        //Português (Brasil)
        if (SelectLanguage == 6)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 80;
            PrzyciskRaycast.zmiennafontsize.prosto = 86;
            Play.text = "Jogar";
            Settings.text = "Configurações";
            Exit.text = "Sair";
            Game.text = "Jogo";
            Graphics.text = "Gráficos";
            Volume.text = "Volume";
            Controls.text = "Controles";
            Language.text = "Idioma";
        }
       
        //Українська
        if (SelectLanguage == 7)
        {
            PrzyciskRaycast.zmiennafontsize.nawodziszsie = 75;
            PrzyciskRaycast.zmiennafontsize.prosto = 80;
            Play.text = "Грати";
            Settings.text = "Налаштування";
            Exit.text = "Вихід";
            Game.text = "Гра";
            Graphics.text = "Графіка";
            Volume.text = "Гучність";
            Controls.text = "Керування";
            Language.text = "Мова";
        }
       
        
        
    }
}
