using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;       // Ссылка на игрока (Rigidbody)
    public Vector3 offset;         // Смещение камеры от игрока
    public float smoothSpeed = 0.7f; // Скорость сглаживания

    void LateUpdate()
    {
        // Желаемая позиция = позиция игрока + смещение
        Vector3 desiredPosition = player.position + offset;

        // Плавное перемещение (чтобы не трусилось)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Если нужно, чтобы камера всегда смотрела на игрока
        // transform.LookAt(player);
    }
}
