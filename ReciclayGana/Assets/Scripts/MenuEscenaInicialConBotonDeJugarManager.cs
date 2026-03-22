using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEscenaInicialConBotonDeJugarManager : MonoBehaviour
{
    public void IrAJugar()
    {
        SceneManager.LoadScene("EscenadeJuego");
    }

    public void IrAInstrucciones()
    {
        SceneManager.LoadScene("EscenaDeInstrucciones");
    }
}

