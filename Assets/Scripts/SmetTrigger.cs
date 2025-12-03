using UnityEngine;

public class SmetTrigger : MonoBehaviour
{
    public GameObject SmetTrigger0;
    public GameObject Player;
    public int SpawnNumer = 0;
    private bool ZaborTrigger = false;
    public Rigidbody PlayerRigidbodyZERO;

    void Start()
    {
        Rigidbody PlayerRigidbodyZERO = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    
    void Update()
    {

        if (ZaborTrigger)
        {
            SpawnNumer++;
            ZaborTrigger = false;
        }
        
    }
    void OnTriggerEnter(Collider other){

        if (other.gameObject.CompareTag("Smert"))
        {
            PlayerRigidbodyZERO.linearVelocity = Vector3.zero;
            if (SpawnNumer == 0)
            {
                Player.transform.position = new Vector3(61.31f, 15.91811f, -1.28f);

            }
            
            
            else if (SpawnNumer == 1)
            {
                Player.transform.position = new Vector3(-239.49f, -46.4f, -1.28f);
            }
            
            else if (SpawnNumer == 2)
            {
                Player.transform.position = new Vector3(-539.49f, -109.4f, -1.28f);
            }
            
            else if (SpawnNumer == 3)
            {
                Player.transform.position = new Vector3(-839.49f, -172.4f, -1.28f);
            }
           
        }
        if (other.gameObject.CompareTag("ZaborTrigger"))
        {
            ZaborTrigger = true;
            Debug.Log("Ok");
        }
    }
    
}
