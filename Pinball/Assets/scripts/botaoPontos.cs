using UnityEngine;

public class botaoPontos : Pontos
{
    Pontos botao = new Pontos();
    
    public int valorPontos = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        botao.adicionarPontos(valorPontos);
    }
}
