using UnityEngine;

public class License : MonoBehaviour
{
public static int StronaNr = 1;
public GameObject Strona1;
public GameObject Strona2;
public GameObject Strona3;
public GameObject Strona4;
public GameObject ButtonPrawo;
public GameObject ButtonLeft;

    // Update is called once per frame
    void Update()
    {
        switch (StronaNr)
        {
            case 1:
            Strona1.SetActive(true);
            Strona2.SetActive(false);
            Strona3.SetActive(false);
            Strona4.SetActive(false);
            ButtonLeft.SetActive(false);
            ButtonPrawo.SetActive(true);
            break;
            case 2:
            Strona1.SetActive(false);
            Strona2.SetActive(true);
            Strona3.SetActive(false);
            Strona4.SetActive(false);
            ButtonLeft.SetActive(true);
            ButtonPrawo.SetActive(true);
            break;
            case 3:
            Strona1.SetActive(false);
            Strona2.SetActive(false);
            Strona3.SetActive(true);
            Strona4.SetActive(false);
            ButtonLeft.SetActive(true);
            ButtonPrawo.SetActive(true);
            break;
            case 4:
            Strona1.SetActive(false);
            Strona2.SetActive(false);
            Strona3.SetActive(false);
            Strona4.SetActive(true);
            ButtonLeft.SetActive(true);
            ButtonPrawo.SetActive(false);
            break;

            
        }
    }
    public void Lewo()
    {
        StronaNr -= 1;
    }
    public void Prawo()
    {
        StronaNr += 1;
    }
}
