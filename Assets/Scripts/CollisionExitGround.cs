using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CollisionExitGround : MonoBehaviour
{
    private Rigidbody rb;
    private float jump = 9;
    public GameObject[]  ZaborZad = new GameObject[3];
    



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    // Update is called once per frame
    void Update()
    {
        // rb.AddForce(Vector3.back * 15f, ForceMode.VelocityChange);
    }
    /**
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerChodzicz.ZmienneChodzenia.onletyt = true;
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ZaborZad.SetActive(false);
        }
    }**/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerSkoku"))
        {
            PlayerChodzicz.ZmienneChodzenia.speedPlayer = 4;

            PlayerChodzicz.ZmienneChodzenia.onletyt = true;

            //ZaborZad.SetActive(false);
            SetActiveAll(ZaborZad, false);
            
            StartCoroutine(SkokKarate());
            
            
                 
                //other.gameObject.CompareTag("zaborZad").SetActive(false);
            
            
            
                
            }
        }
    
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerChodzicz.ZmienneChodzenia.onletyt = false;
            //other.gameObject.CompareTag("zaborZad").SetActive(true);
            //ZaborZad.SetActive(true);
            SetActiveAll(ZaborZad, true);
            Physics.gravity = new Vector3(0, -10f, 0);
        }
    }
    
    private void IwanKarate()
    {
         PlayerChodzicz.ZmienneChodzenia.speedPlayer = 12;
        rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
    }
    private IEnumerator SkokKarate()
    {

        yield return new WaitForSeconds(0.6f);

        IwanKarate();

    }
    public void SetActiveAll(GameObject[] list, bool state)
{
    foreach (var obj in list)
    {
        obj.SetActive(state);
    }
}

    
}
