using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS : MonoBehaviour
{
    private int deathCount = 0;
    public GameObject gameOverUI; // Referencia al objeto del canvas que contiene el mensaje de "Has Muerto"
    public float deathMessageDuration = 2f; // Duraci�n del mensaje de muerte en segundos

    void Start()
    {
        // Desactiva el mensaje de "Has Muerto" al inicio
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

    public void PlayerDied()
    {
        deathCount++;

        // Muestra el mensaje de "Has Muerto"
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
            Invoke("HideDeathMessage", deathMessageDuration); // Oculta el mensaje despu�s de la duraci�n especificada
        }
        else
        {
            Debug.LogWarning("Falta asignar el objeto del canvas de Game Over en el Inspector.");
        }

        if (deathCount >= 3)
        {
            // Muestra el mensaje de "Game Over" y reinicia el nivel despu�s de tres muertes
            Invoke("RestartLevel", deathMessageDuration);
        }
    }

    void HideDeathMessage()
    {
        // Oculta el mensaje de "Has Muerto"
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

    void RestartLevel()
    {
        // Carga la escena actual nuevamente (puedes ajustar el �ndice de la escena seg�n tu configuraci�n)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
