using UnityEngine;

public class ControlDeAudio : MonoBehaviour
{
    public static ControlDeAudio instancia;

    public AudioSource audioSource;

    public AudioClip sonidoDeExito;
    public AudioClip sonidoDeError;

    void Awake()
    {
        instancia = this;

        // 🔥 CLAVE: no destruir al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
    public void SonidoExito()
    {
        audioSource.PlayOneShot(sonidoDeExito);
    }

    public void SonidoError()
    {
        audioSource.PlayOneShot(sonidoDeError);
    }
}