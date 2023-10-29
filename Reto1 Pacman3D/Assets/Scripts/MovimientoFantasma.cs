using UnityEngine;
using System.Collections;

public class MovimientoFantasma : MonoBehaviour
{
    public float velocidad = 1f; // Ajusta la velocidad según sea necesario
    public float suavidadRotacion = 5f; // Controla la suavidad del cambio de dirección
    public float tiempoCambioDireccion = 2f; // Tiempo entre cambios de dirección

    void Start()
    {
        // Inicia la rutina para cambiar la dirección periódicamente
        StartCoroutine(CambiarDireccionPeriodicamente());
    }

    void Update()
    {
        // Mueve el fantasma hacia adelante
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    IEnumerator CambiarDireccionPeriodicamente()
    {
        while (true)
        {
            // Espera un tiempo aleatorio antes de cambiar la dirección
            yield return new WaitForSeconds(Random.Range(tiempoCambioDireccion - 0.5f, tiempoCambioDireccion + 0.5f));
            // Cambia la dirección de rotación aleatoriamente
            Quaternion toRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * suavidadRotacion);
        }
    }
}
