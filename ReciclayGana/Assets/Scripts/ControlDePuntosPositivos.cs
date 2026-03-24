using UnityEngine;
using TMPro;

public class ControlDePuntos : MonoBehaviour
{
    public static ControlDePuntos instancia;

    public int puntos = 0;
    public TextMeshProUGUI TextoPuntos;

    void Awake()
    {
        instancia = this;
    }

    public void SumarPunto()
    {
        puntos++;
        TextoPuntos.text = "Puntos: " + puntos;
    }
}


