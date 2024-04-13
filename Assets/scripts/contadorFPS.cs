using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class contadorFps : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        // Verifica se a cena atual é a cena do jogo antes de iniciar a contagem de FPS
        if (SceneManager.GetActiveScene().name == "Jogo")
        {
            InvokeRepeating(nameof(CalcularFPS), 0, 1f);
        }
        else
        {
            // Desliga o objeto com o script se não estiver na cena do jogo
            gameObject.SetActive(false);
        }
    }

    private void CalcularFPS()
    {
        textMesh.text = (1f / Time.deltaTime).ToString("00") + " FPS";
    }
}
