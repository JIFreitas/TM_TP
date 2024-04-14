using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ContadorFPS : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public GameObject PauseMenu;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        // Verifica se a cena atual é a cena do jogo antes de iniciar a contagem de FPS
        if (SceneManager.GetActiveScene().name == "Jogo")
        {
            InvokeRepeating(nameof(CalcularFPS), 0, 1f);
        }
    }

    private void Update()
    {
        // Desativa o objeto com o script se o jogo estiver pausado
        if (PauseMenu != null && PauseMenu.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    private void CalcularFPS()
    {
        textMesh.text = (1f / Time.deltaTime).ToString("00") + " FPS";
    }
}
