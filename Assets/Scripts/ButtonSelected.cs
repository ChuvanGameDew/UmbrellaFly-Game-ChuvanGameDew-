using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuSelector : MonoBehaviour
{
    public GameObject defaultSelectedButton;

    void Update()
    {
        if(Menu.buttonselect.OnOROff == true)
        {
            // Установить выбранный объект (включает Sprite Swap > Selected)
        EventSystem.current.SetSelectedGameObject(null); // сначала сброс
            EventSystem.current.SetSelectedGameObject(defaultSelectedButton);
            Menu.buttonselect.OnOROff = false;
        }
        
    }
}
