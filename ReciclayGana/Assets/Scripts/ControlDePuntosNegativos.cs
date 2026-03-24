using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ObjetoMalo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        // 🔊 Reproducir sonido (solo si existe)
        if (ControlDeAudio.instancia != null)
        {
            ControlDeAudio.instancia.SonidoError();
            Debug.Log("ENTRO AL IF DE CONTROL DE AUDIO");
        }

        SceneManager.LoadScene("EscenaDeHasPerdido");
    }
}

    IEnumerator IrAEscenaDeHasPerdido()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("EscenaDeHasPerdido");
    }
}

