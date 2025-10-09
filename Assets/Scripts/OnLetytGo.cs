using UnityEngine;

public class OnLetytGo : MonoBehaviour
{
    [Header("Jump Settings")]
    [SerializeField] private float jumpMultiplier = 2500f;

    [Header("Particle Systems")]
    [SerializeField] private ParticleSystem particleSystemComponent1;
    [SerializeField] private ParticleSystem particleSystemComponent2;

    private Rigidbody rb;

    // Zmienne, które odpowiadają za kierunki
    private enum MoveDirection { None, Left, Right }
    private MoveDirection queuedDirection = MoveDirection.None;

    private void Awake()
    {
        // Pobieramy komponent fizyki (Rigidbody)
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Gdy nasz gracz zaczyna lecieć
        if (!PlayerChodzicz.ZmienneChodzenia.onletyt) return;

        // Sprawdza, czy kliknąłeś przyciski A lub D
        if (Input.GetKeyDown(KeyCode.A))
        {
            queuedDirection = MoveDirection.Left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            queuedDirection = MoveDirection.Right;
        }
    }

    private void FixedUpdate()
    {
        // Ruch odbywa się tutaj, bo FixedUpdate działa razem z fizyką
        if (!PlayerChodzicz.ZmienneChodzenia.onletyt) return;

        Vector3 forceDirection = Vector3.zero;

        // Wybieramy kierunek, w którym ma być dodana siła
        switch (queuedDirection)
        {
            case MoveDirection.Left:
                forceDirection = Vector3.back;
                break;
            case MoveDirection.Right:
                forceDirection = Vector3.forward;
                break;
        }

        // Jeśli jakiś kierunek został zapisany, dodajemy siłę
        if (forceDirection != Vector3.zero)
        {
            rb.AddForce(forceDirection * jumpMultiplier, ForceMode.Acceleration);

            // Efekty cząsteczek można odpalić tutaj (zakomentowane na razie)
            // particleSystemComponent1?.Play();
            // particleSystemComponent2?.Play();
        }

        // Reset, żeby nie powtarzać ruchu w kolejnej klatce
        queuedDirection = MoveDirection.None;
    }
}
