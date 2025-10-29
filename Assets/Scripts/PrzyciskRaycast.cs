using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrzyciskRaycast : MonoBehaviour
{
    public LayerMask PrzyciskPlay;
    public LayerMask PrzyciskSettings;
    public LayerMask PrzyciskExit;
    
    public TextMeshProUGUI TextPlay;
    public TextMeshProUGUI TextSettings;
    public TextMeshProUGUI TextExit;
    public class zmiennafontsize
    {
        public static int nawodziszsie = 110;
        public static int prosto = 120;
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f, PrzyciskPlay))
        {
            TextPlay.fontSize = 130;
            

        }
        else
        {
            TextPlay.fontSize = 140;
        }
        if (Physics.Raycast(ray, out hit, 100f, PrzyciskSettings))
        {
            TextSettings.fontSize = zmiennafontsize.nawodziszsie;
            

        }
        else
        {
            TextSettings.fontSize = zmiennafontsize.prosto;
        }
        if (Physics.Raycast(ray, out hit, 100f, PrzyciskExit))
        {
            TextExit.fontSize = 130;
            

        }
        else
        {
            TextExit.fontSize = 140;
        }

    }
    
}
