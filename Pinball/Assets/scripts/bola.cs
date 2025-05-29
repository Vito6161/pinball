using UnityEngine;

public class bola : MonoBehaviour
{
    public int pontuaçãoTotal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.collider.CompareTag("chão"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("25 pontos"))
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
}
