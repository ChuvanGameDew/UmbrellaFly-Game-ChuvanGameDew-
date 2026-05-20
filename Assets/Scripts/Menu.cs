using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject informationPanel;
    public GameObject mainMenu;
    public GameObject WyborMapy;

    public GameObject Settings;

    public GameObject GameButEkr;

    public GameObject VolumeButEkr;

    public GameObject ControlsButEkr;

    public AudioSource buttondown;
    public static  int MapaNr = 0 ;
    public class buttonselect
    {
        public static bool OnOROff = false;
    }

    private SceneController sceneController;
    

    private void Awake()
    {
        sceneController = GetComponent<SceneController>();
        
    }
    private void Update()
    {
        Debug.Log("MapaNr: " +Menu.MapaNr);
    }

    public void OnStartGamePressed()
    {
        WyborMapy.SetActive(!WyborMapy.activeSelf);
        mainMenu.SetActive(!mainMenu.activeSelf);
        //SceneManager.LoadScene(1);
        //SmetTrigger.IloscBoostow.restart = true;
        //sound();
        
    }
    public void Mapa1()
    {
        Menu.MapaNr = 1;
    }
        public void Mapa2()
    {
        Menu.MapaNr = 2;
    }
    public void Mapa3()
    {
        Menu.MapaNr = 3;
    }
        public void PlayMapa()
    {
        sound();
        if(Menu.MapaNr == 1)
        {
        SceneManager.LoadScene(1);
        SmetTrigger.IloscBoostow.restart = true;
        sound();  
        }
        else if(Menu.MapaNr == 2)
        {
        SceneManager.LoadScene(3);
        SmetTrigger.IloscBoostow.restart = true;
        sound();  
        }
        else if(Menu.MapaNr == 3)
        {
        SceneManager.LoadScene(5);
        SmetTrigger.IloscBoostow.restart = true;
        sound();  
        }
        
    }


    public void OnExitPressed()
    {
        Application.Quit();
        sound();
    }
    public void OnClickSettings()
    {
        Settings.SetActive(!Settings.activeSelf);
        mainMenu.SetActive(!mainMenu.activeSelf);
        buttonselect.OnOROff = !buttonselect.OnOROff;
        sound();
        GameButEkr.SetActive(true);
        ControlsButEkr.SetActive(false);
        VolumeButEkr.SetActive(false);
        
    }

    public void OnToggleInformationPressed()
    {
        informationPanel.SetActive(!informationPanel.activeSelf);
        mainMenu.SetActive(!mainMenu.activeSelf);
        sound();
    }


    //screen lose
    public void OnMenuButtonPressed()
    {

        SceneManager.LoadScene(0);
        sound();
    }
    public void OnRestartButtonPressed()
    {
        if(ImageBoost.Mapkol.LicznikMap == 1)
        {
        SceneManager.LoadScene(1);
        SmetTrigger.IloscBoostow.restart = true;
        sound();
        }
        else if(ImageBoost.Mapkol.LicznikMap == 2)
        {
        SceneManager.LoadScene(3);
        SmetTrigger.IloscBoostow.restart = true;
        sound();
        }
        else if(ImageBoost.Mapkol.LicznikMap == 3)
        {
        SceneManager.LoadScene(5);
        SmetTrigger.IloscBoostow.restart = true;
        sound();
        }
        
    }
    public void sound()
    {
        if (buttondown != null)
        buttondown.Play();
        
    }
    
    public void OnClickSettingsMAPA()
    {
         Settings.SetActive(true);
    }
    public void exitSettingsMAPA()
    {
         Settings.SetActive(false);
    }
    public void Game()
    {
        if (GameButEkr != null && VolumeButEkr != null && ControlsButEkr != null) {
        GameButEkr.SetActive(true);
        ControlsButEkr.SetActive(false);
        VolumeButEkr.SetActive(false);
        }
    }
    public void Volume()
    {
        if (GameButEkr != null && VolumeButEkr != null && ControlsButEkr != null) {
        VolumeButEkr.SetActive(true);
        GameButEkr.SetActive(false);
        ControlsButEkr.SetActive(false);
        }

    }
    public void Controls()
    {
        if (GameButEkr != null && VolumeButEkr != null && ControlsButEkr != null) {
        ControlsButEkr.SetActive(true);
        VolumeButEkr.SetActive(false);
        GameButEkr.SetActive(false);
        }

    }
}
