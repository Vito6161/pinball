using UnityEngine;

public class Pontos : MonoBehaviour
{
    public int pontuaçãoTotal = 0;

    public int adicionarPontos(int valorPontos)
    {
        Debug.Log(pontuaçãoTotal);
        return pontuaçãoTotal += valorPontos;
    }
}
