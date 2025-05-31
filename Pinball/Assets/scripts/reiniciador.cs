using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciador : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            Scene cenaAtual = SceneManager.GetActiveScene();
            SceneManager.LoadScene(cenaAtual.name);
        }
    }
}
