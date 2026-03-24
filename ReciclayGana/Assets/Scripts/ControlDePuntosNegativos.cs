using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ObjetoMalo : MonoBehaviour
{
    private bool yaPerdio = false;

    private void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("COLISION DETECTADA");

    if (other.CompareTag("Player"))
    {
        Debug.Log("TOCO PLAYER");
        Debug.Log("MI SCRIPT NUEVO");

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

