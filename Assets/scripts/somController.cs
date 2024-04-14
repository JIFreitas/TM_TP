using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class somController : MonoBehaviour
{
    private bool estadoSom = true;
    [SerializeField] private AudioSource somFundo;
    [SerializeField] private Sprite somLigadoSprite;
    [SerializeField] private Sprite somDesligadoSprite;
    [SerializeField] private UnityEngine.UI.Image muteImage;

    public void ligarDesligarSom(){
        estadoSom = !estadoSom;
        somFundo.enabled = estadoSom;

        if(estadoSom){
            muteImage.sprite = somLigadoSprite;
        } else{
            muteImage.sprite = somDesligadoSprite;
        }
    }

    public void volumeSom(float value){
        somFundo.volume = value;
    }
}
