using UnityEngine;

public class PulsoObjeto : MonoBehaviour
{
    public float velocidad = 2f;
    public float tamañoMin = 0.9f;
    public float tamañoMax = 1.1f;

    void Update()
    {
        float escala = Mathf.Lerp(tamañoMin, tamañoMax, (Mathf.Sin(Time.time * velocidad) + 1f) / 2f);
        transform.localScale = new Vector3(escala, escala, 1);
    }
}