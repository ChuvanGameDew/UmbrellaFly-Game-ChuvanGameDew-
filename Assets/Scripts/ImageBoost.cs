using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageBoost : MonoBehaviour
{
  public GameObject[] platformIloscBostow = new GameObject[3];
  public GameObject[] platformIloscSuperBostow = new GameObject[1];
  public GameObject[] Heart = new GameObject[2];


  public class Mapkol{
  
  public static int LicznikMap ;
  }
  private void Start() {
    //SmetTrigger.IloscBoostow.IloscBoostu = 0;
    //SmetTrigger.IloscBoostow.IloscSuperBoostu = 0;
    //SmetTrigger.IloscBoostow.HeartIlosc = 3;
  }

    // Update is called once per frame
    void Update()
    {
        switch (SmetTrigger.IloscBoostow.IloscBoostu )
        {
            case 1:
            platformIloscBostow[0].SetActive(true);
            platformIloscBostow[1].SetActive(false);
            platformIloscBostow[2].SetActive(false);
            platformIloscBostow[3].SetActive(false);
            break;
            case 2:
            platformIloscBostow[0].SetActive(true);
            platformIloscBostow[1].SetActive(true);
            platformIloscBostow[2].SetActive(false);
            platformIloscBostow[3].SetActive(false);
            break;
            case 3:
            platformIloscBostow[0].SetActive(true);
            platformIloscBostow[1].SetActive(true);
            platformIloscBostow[2].SetActive(true);
            platformIloscBostow[3].SetActive(false);
            break ;
            case 4:
            platformIloscBostow[0].SetActive(true);
            platformIloscBostow[1].SetActive(true);
            platformIloscBostow[2].SetActive(true);
            platformIloscBostow[3].SetActive(true);
            break ;
            default:
            platformIloscBostow[0].SetActive(false);
            platformIloscBostow[1].SetActive(false);
            platformIloscBostow[2].SetActive(false);
            platformIloscBostow[3].SetActive(false);
            break;
            
        }
        if(SmetTrigger.IloscBoostow.IloscSuperBoostu > 0)
        {
            platformIloscSuperBostow[0].SetActive(true);
        }
        else
        {
            platformIloscSuperBostow[0].SetActive(false);
        }

        switch (SmetTrigger.IloscBoostow.HeartIlosc )
        {
            case 1:
            Heart[0].SetActive(true);
            Heart[1].SetActive(false);
            Heart[2].SetActive(false);
            
            break;
            case 2:
            Heart[0].SetActive(true);
            Heart[1].SetActive(true);
            Heart[2].SetActive(false);
            break;
            case 3:
            Heart[0].SetActive(true);
            Heart[1].SetActive(true);
            Heart[2].SetActive(true);
            break ;
            
            default:
            Heart[0].SetActive(false);
            Heart[1].SetActive(false);
            Heart[2].SetActive(false);
            SceneManager.LoadScene(2);
            break;
            
        }
        Debug.Log("Mapkol.LicznikMap: " + Mapkol.LicznikMap);
    }
     private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Mapa1"))
        {
            Mapkol.LicznikMap = 1;
        }
        if (other.gameObject.CompareTag("Mapa2"))
        {
            Mapkol.LicznikMap = 2;
        }
        if (other.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
