using UnityEngine;

public class OnLetytGo : MonoBehaviour
{
    private Rigidbody rb;
    
    private float JumpMonoznik = 2500;
    private float JumpMonoznikW = 900;
    private bool Akey = false;
    private bool Dkey = false;
    private bool Wkey = false;
    public float startTime = 5f;

    // Particle system - teraz prywatne z możliwością ustawienia w inspektorze
    [SerializeField] private ParticleSystem particleSystemComponent1;
    [SerializeField] private ParticleSystem particleSystemComponent2;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            if (Akey == true)
            {
                //particleSystemComponent1.Simulate(startTime, withChildren: true, restart: true);
                //particleSystemComponent1.Play();
                //particleSystemComponent2.Play();
                rb.AddForce(Vector3.back * JumpMonoznik, ForceMode.Acceleration);
                Akey = false;
            }
            if (Dkey == true)
            {
                rb.AddForce(Vector3.forward * JumpMonoznik, ForceMode.Acceleration);
                Dkey = false;
            }
            if(Wkey == true)
            {
                
                //rb.mass = 5;
                
                rb.AddForce(Vector3.up * JumpMonoznikW, ForceMode.Acceleration);
                Wkey = false;
                 
                //rb.linearDamping = 1f;
                
                
            }
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            Akey = true;
        }
        if (Input.GetKeyDown(KeyCode.D) && PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            Dkey = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            Wkey = true;
        }

    }
    void OnTriggerEnter(Collider other){
            if (other.gameObject.CompareTag("22N"))
            {
                Physics.gravity = new Vector3(0, -22f, 0);
                
            }
        }
}
