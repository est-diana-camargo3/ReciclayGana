using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerDeBotonesEscenadeinstrucciones : MonoBehaviour
{
     public void IrAInicio() // 🏠 BOTÓN HOME
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("EscenaInicialConBotonDeJugar");
    }
    
    public void IrAJugar()
    {
        SceneManager.LoadScene("EscenadeJuego");
    }

    public void IrAEscenaInicial()
    {
        SceneManager.LoadScene("EscenaInicialConBotonDeJugar");
    }
}

