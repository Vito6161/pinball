using UnityEngine;

public class bola : MonoBehaviour
{
    public int pontuaçãoTotal;
    private Rigidbody2D rb;
    private float forcaImpulso = 30f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D colisao) 
    {
        if (colisao.collider.CompareTag("chão")) // destroi a bola caso ela encoste no chão
        {
            Destroy(gameObject);
            Debug.Log("VOCÊ PERDEU!!!!!!!");
        }
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("25 pontos")) //sistema de pontuação
        {
            pontuaçãoTotal += 25;
        }
        else if (colisao.CompareTag("50 pontos"))
        {
            pontuaçãoTotal += 50;
        }
        else if (colisao.CompareTag("100 pontos"))
        {
            pontuaçãoTotal += 100;
        }

        Debug.Log(pontuaçãoTotal);
    }

    void OnTriggerStay2D(Collider2D area)
    {
        if (area.CompareTag("inicio")) //sistema de impulso inicial
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector2.up * forcaImpulso, ForceMode2D.Impulse);
            }


            
        }
        
    }
}
