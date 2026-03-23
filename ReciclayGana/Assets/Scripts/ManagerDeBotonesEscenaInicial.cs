using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerDeBotonesEscenaInicial : MonoBehaviour
{
    public void IrAJugar()   {       SceneManager.LoadScene("EscenadeJuego");    }
    public void IrAInstrucciones()   {      SceneManager.LoadScene("EscenaDeInstrucciones");    }
    public void IrASalir()     {        
        #if UNITY_EDITOR            
        UnityEditor.EditorApplication.isPlaying = false;
        #else           
        Application.Quit();        
        #endif    
}
}



