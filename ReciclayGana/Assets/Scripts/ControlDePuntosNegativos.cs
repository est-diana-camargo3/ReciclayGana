using UnityEngine;
public class ObjetoMalo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PERDISTE");

            // Reiniciar escena
            UnityEngine.SceneManagement.SceneManager.LoadScene("EscenaDeJuego");
        }
    }
}

