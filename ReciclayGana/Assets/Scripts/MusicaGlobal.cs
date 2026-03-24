using UnityEngine;

public class MusicaGlobal : MonoBehaviour
{
    private static MusicaGlobal instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // 🔥 NO se destruye al cambiar escena
        }
        else
        {
            Destroy(gameObject); // evita duplicados
        }
    }
}