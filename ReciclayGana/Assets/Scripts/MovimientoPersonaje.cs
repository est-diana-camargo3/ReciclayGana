using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;

    public Sprite frente;
    public Sprite espalda;
    public Sprite derecha;
    public Sprite izquierda;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 movimiento;

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

        // Cambiar sprite según dirección
        if (movX > 0)
        {
            sr.sprite = derecha;
        }
        else if (movX < 0)
        {
            sr.sprite = izquierda;
        }
        else if (movY > 0)
        {
            sr.sprite = espalda;
        }
        else if (movY < 0)
        {
            sr.sprite = frente;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}