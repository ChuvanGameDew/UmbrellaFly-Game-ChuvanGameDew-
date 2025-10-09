using UnityEngine;
using System;
using System.Collections;

public class Animation : MonoBehaviour
{


    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        
    }


    void Update()
    {
        if (PlayerChodzicz.ZmienneChodzenia.onletyt == false)
        {
            anim.SetBool("Jump", false);
            anim.SetBool("GoLeft", false);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                anim.SetBool("Run", true);
            }
            else
            {
                anim.SetBool("Run", false);
            }

        }

        if (PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Jump", true);


            if (Input.GetKeyDown(KeyCode.A) )
            {
                transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                anim.SetBool("GoLeft", true);

            }
            if ( Input.GetKeyDown(KeyCode.D))
            {
                transform.localScale = new Vector3(0.2f, 0.2f, -0.2f);
                anim.SetBool("GoLeft", true);

            }
        



        }



    }
    
}
