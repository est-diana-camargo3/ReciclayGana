using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerDeBotonesEscenaDeJuego : MonoBehaviour
{
    private bool juegoEnPausa = false;
    private bool sonidoActivo = true;

    public void IrAInstrucciones()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("EscenaDeInstrucciones");
    }

    public void IrAInicio() // 🏠 BOTÓN HOME
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("EscenaInicialConBotonDeJugar");
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        juegoEnPausa = false;
        AplicarEstadoAudio();
    }

    public void PausarJuego()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        juegoEnPausa = true;
    }

    public void ToggleSonido()
    {
        sonidoActivo = !sonidoActivo;
        AplicarEstadoAudio();
    }

    void AplicarEstadoAudio()
    {
        AudioListener.volume = sonidoActivo ? 1f : 0f;
    }
}