using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerDeBotonesEscenaDeHasPerdido : MonoBehaviour
{
    public void IrAJugar()   {       SceneManager.LoadScene("EscenadeJuego");    }
    public void IrASalir()     {        
 #if UNITY_EDITOR            
UnityEditor.EditorApplication.isPlaying = false;
        	#else           
Application.Quit();        
#endif    
}
}

