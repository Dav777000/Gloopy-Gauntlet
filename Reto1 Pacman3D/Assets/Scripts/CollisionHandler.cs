using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private int deathCount = 0;
    public Transform respawnPoint; // El punto donde el jugador reaparecerá después de colisionar con un fantasma

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Mata al jugador y respawnea después de un breve retraso
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        deathCount++;

        // Si el jugador ha muerto tres veces, reinicia el juego
        if (deathCount >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            // Reposiciona al jugador en el punto de reaparición
            transform.position = respawnPoint.position;
        }
    }
}
