using UnityEngine;
using System;
using System.Collections;

public class Animation2 : MonoBehaviour
{


    private Animator anim;
    private int prowerkaGOLeft = 0;
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
            prowerkaGOLeft = 0;
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            anim.SetBool("CollidSet", true);
            anim.SetBool("Jump", false);
            ResetLeftGoAnimations();
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                anim.SetBool("GoPrzod", true);
            }
            else
            {
                anim.SetBool("GoPrzod", false);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("ChodziczRight", true);
                    //transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f); // obrót w prawo
                }
                else
                {
                    anim.SetBool("ChodziczLeft", true);
                    //transform.localScale = new Vector3(0.2f, 0.2f, 0.2f); // obrót w lewo
                }
            }
            else
            {
                anim.SetBool("ChodziczLeft", false);
                anim.SetBool("ChodziczRight", false);
            }


        }

        if (PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            anim.SetBool("CollidSet", false);
            anim.SetBool("GoPrzod", false);
            anim.SetBool("ChodziczLeft", false);
            anim.SetBool("ChodziczRight", false);
            anim.SetBool("Jump", true);


            if (Input.GetKeyDown(KeyCode.A))
            {
                ResetLeftGoAnimations();
                if (prowerkaGOLeft == 0)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    anim.SetBool("LeftGo1", true);
                    prowerkaGOLeft += 1;
                }
                else if (prowerkaGOLeft == 1)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    anim.SetBool("LeftGo2", true);
                    prowerkaGOLeft += 1;

                }
                else if (prowerkaGOLeft == 2)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    anim.SetBool("LeftGo3", true);
                    prowerkaGOLeft += 1;
                }
                else if (prowerkaGOLeft == 3)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    anim.SetBool("LeftGo4", true);
                    prowerkaGOLeft += 1;
                }


            }


            if (Input.GetKeyDown(KeyCode.D))
            {
                ResetLeftGoAnimations();
                if (prowerkaGOLeft == 0)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, -0.2f);
                    anim.SetBool("LeftGo1", true);
                    prowerkaGOLeft += 1;
                }
                else if (prowerkaGOLeft == 1)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, -0.2f);

                    anim.SetBool("LeftGo2", true);
                    prowerkaGOLeft += 1;

                }
                else if (prowerkaGOLeft == 2)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, -0.2f);
                    anim.SetBool("LeftGo3", true);
                    prowerkaGOLeft += 1;
                }
                 else if (prowerkaGOLeft == 3)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, -0.2f);
                    anim.SetBool("LeftGo4", true);
                    prowerkaGOLeft += 1;
                }

            }





        }



    }
    private void ResetLeftGoAnimations()
{
    anim.SetBool("LeftGo1", false);
    anim.SetBool("LeftGo2", false);
    anim.SetBool("LeftGo3", false);
    anim.SetBool("LeftGo4", false);
}
    
}
