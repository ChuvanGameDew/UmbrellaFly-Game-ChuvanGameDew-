using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject informationPanel;
    public GameObject mainMenu;

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
