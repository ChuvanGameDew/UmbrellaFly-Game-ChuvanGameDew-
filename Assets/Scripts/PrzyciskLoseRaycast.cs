using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrzyciskLoseRaycast : MonoBehaviour
{
        //ScreenLose
    public LayerMask PrzyciskMenu;
    public LayerMask PrzyciskRestart;
    public TextMeshProUGUI TextMenu;
    public TextMeshProUGUI TextRestart;
    
     public class zmiennafontsize
    {
        public static int nawodziszsie = 110;
        public static int prosto = 120;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //ScreenLose
        if (Physics.Raycast(ray, out hit, 100f, PrzyciskMenu))
        {
            TextMenu.fontSize = zmiennafontsize.nawodziszsie;
            

        }
        else
        {
            TextMenu.fontSize = zmiennafontsize.prosto;
        }
        if (Physics.Raycast(ray, out hit, 100f, PrzyciskRestart))
        {
            TextRestart.fontSize = zmiennafontsize.nawodziszsie;
            

        }
        else
        {
            TextRestart.fontSize = zmiennafontsize.prosto;
        }

    }
}
