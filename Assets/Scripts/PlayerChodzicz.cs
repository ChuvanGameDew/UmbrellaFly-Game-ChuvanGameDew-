using UnityEngine;

public class PlayerChodzicz : MonoBehaviour
{

    //public GameObject igrok;
    private float hjump = -1;
    
    public Vector3 chodzicz = new Vector3(-(ZmienneChodzenia.v), 0, ZmienneChodzenia.h);

    private Rigidbody rb;
    

    // Update is called once per frame
    public class ZmienneChodzenia
    {
        public static float v;
        public static float h;
        public static int speedPlayer = 12;
        public static bool onletyt = false;
        

    }//rb.AddForce(Vector3.forward * 15f, ForceMode.VelocityChange);


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {

        ZmienneChodzenia.v = Input.GetAxis("Vertical");
        ZmienneChodzenia.h = Input.GetAxis("Horizontal");

        if (ZmienneChodzenia.onletyt == false)
        {

            chodzicz = new Vector3(-(ZmienneChodzenia.v), 0, ZmienneChodzenia.h);
            
        }
        else
        {
            chodzicz = new Vector3(hjump * 1.42f, 0, 0);
            //rb.AddForce(new Vector3(-1, 0, 0));
            

        }
    
            
            //transform.Translate(chodzicz * speedPlayer * Time.deltaTime);
        

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = Vector3.Lerp(
        rb.linearVelocity, 
        new Vector3(chodzicz.x * ZmienneChodzenia.speedPlayer, rb.linearVelocity.y, chodzicz.z * ZmienneChodzenia.speedPlayer),
        0.1f // <- коэффициент сглаживания (0.05–0.2 = плавно, >0.3 = резче)
);
            
            //rb.linearVelocity = new Vector3(chodzicz.x * speedPlayer, rb.linearVelocity.y, chodzicz.z * speedPlayer);
            
       
    }
    
    
        
}
