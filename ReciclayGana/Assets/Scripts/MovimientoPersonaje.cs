using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;

    public Sprite frente;
    public Sprite espalda;

    // 🔥 AHORA SON LISTAS (arrays)
    public Sprite[] derechaAnim;
    public Sprite[] izquierdaAnim;

    public float tiempoAnimacion = 0.15f; // velocidad del "caminar"

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 movimiento;

    private float contadorTiempo;
    private int indiceSprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");

        // 🔥 BLOQUEAR DIAGONALES
        if (movX != 0)
        {
            movY = 0;
        }

        movimiento = new Vector2(movX, movY).normalized;

        // 🔥 ANIMACIÓN DERECHA
        if (movX > 0)
        {
            Animar(derechaAnim);
        }
        // 🔥 ANIMACIÓN IZQUIERDA
        else if (movX < 0)
        {
            Animar(izquierdaAnim);
        }
        else if (movY > 0)
        {
            sr.sprite = espalda;
            ResetAnimacion();
        }
        else if (movY < 0)
        {
            sr.sprite = frente;
            ResetAnimacion();
        }
        else
        {
            // 🔥 QUIETO → vuelve al primer sprite
            ResetAnimacion();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }

    // 🔥 FUNCIÓN DE ANIMACIÓN
    void Animar(Sprite[] animacion)
    {
        contadorTiempo += Time.deltaTime;

        if (contadorTiempo >= tiempoAnimacion)
        {
            contadorTiempo = 0f;
            indiceSprite++;

            if (indiceSprite >= animacion.Length)
            {
                indiceSprite = 0;
            }

            sr.sprite = animacion[indiceSprite];
        }
    }

    // 🔥 REINICIAR ANIMACIÓN
    void ResetAnimacion()
    {
        contadorTiempo = 0f;
        indiceSprite = 0;
    }
}