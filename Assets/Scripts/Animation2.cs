using UnityEngine;
using System;
using System.Collections;

// Ten skrypt odpowiada za animacje gracza w grze.
// Zmieniam tutaj animacje w zależności od tego, czy gracz stoi, chodzi, czy skacze.
public class Animation2 : MonoBehaviour
{
    // Zmienna do animatora (steruje animacjami)
    private Animator anim;

    // Licznik, który sprawdza, która animacja chodzenia w lewo ma się włączyć
    private int prowerkaGOLeft = 0;

    // Funkcja Awake włącza się zanim gra się zacznie
    private void Awake()
    {
        // Tutaj pobieram komponent Animatora z obiektu gracza
        anim = GetComponent<Animator>();
    }

    // Start uruchamia się raz po rozpoczęciu gry
    private void Start()
    {
        // Na razie nic tu nie robię, ale można coś dodać później
    }

    // Update działa w każdej klatce gry
    void Update()
    {
        // Sprawdzam, czy gracz NIE jest w locie (czyli stoi na ziemi)
        if (PlayerChodzicz.ZmienneChodzenia.onletyt == false)
        {
            // Resetuję licznik animacji chodzenia w lewo
            prowerkaGOLeft = 0;

            // Ustawiam wielkość postaci (normalna pozycja)
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            // Ustawiam odpowiednie animacje, gdy gracz stoi na ziemi
            anim.SetBool("CollidSet", true);
            anim.SetBool("Jump", false);

            // Resetuję animacje lewego chodzenia
            ResetLeftGoAnimations();

            // Jeśli gracz wciska W lub S to znaczy że idzie do przodu lub do tyłu
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                anim.SetBool("GoPrzod", true);
            }
            else
            {
                anim.SetBool("GoPrzod", false);
            }

            // Jeśli gracz wciska A albo D to idzie w lewo lub w prawo
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.D))
                {
                    // Idzie w prawo
                    anim.SetBool("ChodziczRight", true);
                    // transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f); // ewentualny obrót
                }
                else
                {
                    // Idzie w lewo
                    anim.SetBool("ChodziczLeft", true);
                    // transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                }
            }
            else
            {
                // Jeśli nic nie wciska, to nie idzie
                anim.SetBool("ChodziczLeft", false);
                anim.SetBool("ChodziczRight", false);
            }
        }

        // Tutaj sprawdzam, jeśli gracz jest w locie (skacze)
        if (PlayerChodzicz.ZmienneChodzenia.onletyt == true)
        {
            // Wyłączam animacje chodzenia i kolizji, a włączam skakanie
            anim.SetBool("CollidSet", false);
            anim.SetBool("GoPrzod", false);
            anim.SetBool("ChodziczLeft", false);
            anim.SetBool("ChodziczRight", false);
            anim.SetBool("Jump", true);

            // Jeśli gracz naciska A, to postać obraca się w lewo i animacja się zmienia
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Reset animacji
                ResetLeftGoAnimations();

                // Kolejne animacje w zależności od tego, który raz wciskam A
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

            // To samo tylko dla klawisza D (czyli w prawo)
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

    // Ta funkcja resetuje wszystkie animacje lewej strony, żeby się nie nakładały
    private void ResetLeftGoAnimations()
    {
        anim.SetBool("LeftGo1", false);
        anim.SetBool("LeftGo2", false);
        anim.SetBool("LeftGo3", false);
        anim.SetBool("LeftGo4", false);
    }
}
