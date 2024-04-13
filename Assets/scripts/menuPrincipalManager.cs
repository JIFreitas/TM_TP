using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string Jogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

    public void Jogar(){
        SceneManager.LoadScene(Jogo);
    }

    public void AbrirOpcoes(){
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes(){
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }
    public void SairJogo(){
        Debug.Log("A sair do jogo...");
        Application.Quit();
    }
}
