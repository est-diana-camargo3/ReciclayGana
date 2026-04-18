using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerDeBotonesEscenaDeJuego : MonoBehaviour
{
    private bool juegoEnPausa = false;
    private bool sonidoActivo = true;

    // 🔙 Ir a instrucciones
    public void IrAInstrucciones()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("EscenaDeInstrucciones");
    }

    // ▶️ Play
    public void ReanudarJuego()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        juegoEnPausa = false;

        AplicarEstadoAudio();
    }

    // ⏸ Pausa
    public void PausarJuego()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        juegoEnPausa = true;
    }

    // 🔇 Toggle sonido
    public void ToggleSonido()
    {
        sonidoActivo = !sonidoActivo;

        AplicarEstadoAudio();

        Debug.Log("Sonido activo: " + sonidoActivo);
    }

    void AplicarEstadoAudio()
    {
        if (sonidoActivo)
        {
            AudioListener.volume = 1f;
        }
        else
        {
            AudioListener.volume = 0f;
        }
    }
}