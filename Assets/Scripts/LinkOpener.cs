using UnityEngine;

public class LinkOpener : MonoBehaviour
{
    public void Open(string url)
    {
        Debug.Log("Opening: " + url);
        Application.OpenURL(url);
    }
}
