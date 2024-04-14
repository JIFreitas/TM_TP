using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraDeVida : MonoBehaviour
{
    [SerializeField] private Image barraDeVidaImage;
    
    private Transform myCamera;

    private void Awake(){
        myCamera = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(transform.position + myCamera.forward);    // Para a barra de vida ficar sempre voltada para nós
    }

    public void alterarBarraDeVida(int vidaAtual, int vidaTotal){
        barraDeVidaImage.fillAmount = (float) vidaAtual / vidaTotal;
    }
}
