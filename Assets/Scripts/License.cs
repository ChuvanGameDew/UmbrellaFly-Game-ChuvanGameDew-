using UnityEngine;

public class License : MonoBehaviour
{
    public GameObject Strona1;
    public GameObject Strona2;
    public GameObject Strona3;
    public GameObject Strona4;
    public GameObject PrzyciskRight;
    public GameObject PrzyciskLeft;
    
    public static int jakaStrona = 1;
    // Update is called once per frame
    void Update()
    {
        switch (jakaStrona )
        {
            case 1:
            Strona1.SetActive(true);
            Strona2.SetActive(false);
            Strona3.SetActive(false);
            Strona4.SetActive(false);
            PrzyciskRight.SetActive(true);
            PrzyciskLeft.SetActive(false);
            break;
            case 2:
            Strona1.SetActive(false);
            Strona2.SetActive(true);
            Strona3.SetActive(false);
            Strona4.SetActive(false);
            PrzyciskRight.SetActive(true);
            PrzyciskLeft.SetActive(true);
            break;
            case 3:
            Strona1.SetActive(false);
            Strona2.SetActive(false);
            Strona3.SetActive(true);
            Strona4.SetActive(false);
            PrzyciskRight.SetActive(true);
            PrzyciskLeft.SetActive(true);
            break ;
            case 4:
            Strona1.SetActive(false);
            Strona2.SetActive(false);
            Strona3.SetActive(false);
            Strona4.SetActive(true);
            PrzyciskRight.SetActive(false);
            PrzyciskLeft.SetActive(true);
            break ;
            //default:

            //break;
            
        }

        
        
    }
    public void RightButton()
    {
        jakaStrona++;
    }
        public void LeftButton()
    {
        jakaStrona--;
    }
    public void Wyjsc()
    {
        jakaStrona = 1;
    }

    //Links
        //strona1
        public void OnLink1Pressed1()
    {
         Application.OpenURL("https://fonts.google.com/specimen/Irish+Grover");
         
    }

    public void OnLink2Pressed1()
    {
         Application.OpenURL("https://fonts.google.com/specimen/Itim");
         
    }
    public void OnLink3Pressed1()
    {
         Application.OpenURL("https://assetstore.unity.com/");
         
    }
        //strona2
    
    public void OnLink1Pressed2()
    {
         Application.OpenURL("https://dustyroom.com/free-casual-game-sounds/");
         
    }

    public void OnLink2Pressed2()
    {
         Application.OpenURL("https://opengameart.org/content/sunset-walk-ambient-quiet-sweet-loop");
         
    }
    public void OnLink3Pressed2()
    {
         Application.OpenURL("https://opengameart.org/content/two-platformer-game-music");
         
    }
        //strona3
    public void OnLink1Pressed3()
    {
         Application.OpenURL("https://pixabay.com/sound-effects/film-special-effects-footsteps-in-grass-and-picking-82739/");
         
    }

    public void OnLink2Pressed3()
    {
         Application.OpenURL("https://opengameart.org/content/jump-landing-sound");
         
    }
    public void OnLink3Pressed3()
    {
         Application.OpenURL("https://pixabay.com/sound-effects/film-special-effects-swoosh-quick-swipe-460351/");
         
    }
        //strona4
    public void OnLink1Pressed4()
    {
         Application.OpenURL("https://mmkhlv.itch.io/game-interface-ui-kit");
         
    }

    public void OnLink2Pressed4()
    {
         Application.OpenURL("https://opengameart.org/content/simple-keyboard-input-prompts");
    }

}
