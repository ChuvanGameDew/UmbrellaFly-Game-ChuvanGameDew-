using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject informationPanel;
    public GameObject mainMenu;

    public GameObject Settings;
    public class buttonselect
    {
        public static bool OnOROff = false;
    }

    private SceneController sceneController;
    

    private void Awake()
    {
        sceneController = GetComponent<SceneController>();
        
    }

    public void OnStartGamePressed()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }
    public void OnClickSettings()
    {
        Settings.SetActive(!Settings.activeSelf);
        mainMenu.SetActive(!mainMenu.activeSelf);
        buttonselect.OnOROff = !buttonselect.OnOROff;
    }

    public void OnToggleInformationPressed()
    {
        informationPanel.SetActive(!informationPanel.activeSelf);
        mainMenu.SetActive(!mainMenu.activeSelf);
    }

    public void OnLink1Pressed()
    {
         Application.OpenURL("https://fonts.google.com/specimen/Irish+Grover");
    }

    public void OnLink2Pressed()
    {
         Application.OpenURL("https://fonts.google.com/specimen/Itim");
    }
}
