using UnityEngine;

public class bola : MonoBehaviour
{
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
        Debug.Log("bateuuuuuuuuuuuuu");

        if (colisao.collider.CompareTag("chão"))
        {
            Destroy(gameObject);
            Debug.Log("bateu");
        }
    }
}
