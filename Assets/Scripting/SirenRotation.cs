using UnityEngine;

/// <summary>
/// Hace girar las luces de emergencia alrededor del eje Y del pivote.
/// Se asigna únicamente al objeto Siren_Pivot.
/// </summary>
public class SirenRotation : MonoBehaviour
{
    [Tooltip("Velocidad de giro en grados por segundo.")]
    public float rotationSpeed = 360f;

    void Update()
    {
        // Time.deltaTime convierte la velocidad a "grados por segundo",
        // así el giro es igual de rápido con 30 o con 144 FPS.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}