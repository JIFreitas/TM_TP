using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    private int vidaAtual;
    private int vidaTotal = 100;

    [SerializeField] private barraDeVida barraDeVida;

    private void Start(){
        vidaAtual = vidaTotal;

        barraDeVida.alterarBarraDeVida(vidaAtual, vidaTotal);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){    // Testar se está a sofrer dano
            AplicarDano(10);
        }
    }

    private void AplicarDano(int dano){
        vidaAtual -= 10;
        barraDeVida.alterarBarraDeVida(vidaAtual, vidaTotal);
    }
}
