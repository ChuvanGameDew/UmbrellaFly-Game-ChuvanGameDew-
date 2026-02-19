using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public  GameObject PauseGameMenu;
    public class Pause
    {
        public static bool PauseGame = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause.PauseGame)
            {
                Resume();
            }
            else
            {
                PauseS();
            }
        }
        
    }
    public void Resume()
    {
        PauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        Pause.PauseGame = false;
    }
    public void PauseS()
    {
        PauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        Pause.PauseGame = true;
    }
    public void Play()
    {
        PauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        Pause.PauseGame = false;
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Settings()
    {
        
    }
}
