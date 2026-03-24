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

        SceneManager.LoadScene("EscenaDeHasPerdido");
    }
}

    IEnumerator IrAEscenaDeHasPerdido()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("EscenaDeHasPerdido");
    }
}

