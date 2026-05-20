using UnityEngine;

public class SmetTrigger : MonoBehaviour
{
    public GameObject SmetTrigger0;

    
    public GameObject Player;
    public int SpawnNumer = 0;
    private bool ZaborTrigger = false;
    
    
    public Rigidbody PlayerRigidbodyZERO;

    public class IloscBoostow
    {
        public static int IloscBoostu = 0;
        public static int IloscSuperBoostu = 0;
        public static int HeartIlosc = 3;
        public static bool restart = true;
    }

    private void Awake() {
    IloscBoostow.IloscBoostu = 0;
    IloscBoostow.IloscSuperBoostu = 0;
    IloscBoostow.HeartIlosc = 3;
    SpawnNumer = 0;
    }
    void Start()
    {
        Rigidbody PlayerRigidbodyZERO = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    
    void Update()
    {
        /**
        if(IloscBoostow.restart){
        Player.transform.position = new Vector3(61.31f, 15.91811f, -1.28f);
        IloscBoostow.restart = false;
        }
        **/
        
        if (ZaborTrigger)
        {
            SpawnNumer++;
            ZaborTrigger = false;
        }
        //Debug.Log("ilosc boostow:  " + IloscBoostow.IloscBoostu);
        Debug.Log("IloscBoostow.IloscSuperBoostu: " + IloscBoostow.IloscSuperBoostu);

        
    }
    void OnTriggerEnter(Collider other){

        if (other.gameObject.CompareTag("Smert") )
        {
            --IloscBoostow.HeartIlosc;
            PlayerRigidbodyZERO.linearVelocity = Vector3.zero;
            if(SmetTrigger.IloscBoostow.HeartIlosc >= 1){
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
        }
        //PlatformIloscBoostow
          //Debug.Log("TRIGGER wszedł: " + other.name);
          
            if (other.gameObject.CompareTag("0 Platform"))
            {
                IloscBoostow.IloscBoostu = 0;
            }
            if (other.gameObject.CompareTag("1 Platform"))
            { 
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("2 Platform"))
            {
                IloscBoostow.IloscBoostu = 0;
            }
            if (other.gameObject.CompareTag("3 Platform"))
            {
                IloscBoostow.IloscBoostu = 2;
            }
              if (other.gameObject.CompareTag("4 Platform"))
            {
                IloscBoostow.IloscBoostu = 0;
            }
             if (other.gameObject.CompareTag("5 Platform"))
            {
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("6 Platform"))
            {
                IloscBoostow.IloscBoostu = 2;
            }
             if (other.gameObject.CompareTag("7 Platform"))
            {
                IloscBoostow.IloscBoostu = 2;
            }
             if (other.gameObject.CompareTag("8 Platform"))
            {         
                IloscBoostow.IloscBoostu = 2;
            }
             if (other.gameObject.CompareTag("8 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("9 Platform"))
            {               
                IloscBoostow.IloscBoostu = 0;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("10 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("11 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("12 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("13 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("14 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("15 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("16 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("17 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("18 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("19 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("20 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("21 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("22 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("23 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("24 Platform"))
            {  
                IloscBoostow.IloscBoostu = 0;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("25 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("26 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("27 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("28 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("29 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("30 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("31 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("32 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("33 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("34 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("35 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("36 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
            }
            if (other.gameObject.CompareTag("37 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("38 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("39 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("40 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("41 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
            }
            if (other.gameObject.CompareTag("42 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
            }
            if (other.gameObject.CompareTag("43 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                
            }
            if (other.gameObject.CompareTag("44 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                
            }
            if (other.gameObject.CompareTag("45 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                
            }
            if (other.gameObject.CompareTag("46 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("47 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("48 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("49 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("50 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("51 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("52 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("53 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("54 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("55 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("56 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("57 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("58 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("59 Platform"))
            {  
                IloscBoostow.IloscBoostu = 4;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            if (other.gameObject.CompareTag("60 Platform"))
            {  
                IloscBoostow.IloscBoostu = 2;
                IloscBoostow.IloscSuperBoostu = 1;
                
            }
            


        //
        if (other.gameObject.CompareTag("ZaborTrigger"))
        {
            ZaborTrigger = true;
            Debug.Log("Ok");
        }
    }
    public void OnCollisionEnter(Collision collision) {
      
    }
    
}
