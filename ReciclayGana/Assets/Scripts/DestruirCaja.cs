using UnityEngine;

public class Recolectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ControlDePuntos.instancia.SumarPunto();

            // 🔊 SONIDO DE EXITO
            ControlDeAudio.instancia.SonidoExito();

            Destroy(gameObject);
        }
    }
}

