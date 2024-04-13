using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        // Mantém o mesmo x e y da câmera e define a posição z para a posição atual do jogador
        Vector3 newPosition = new Vector3(player.position.x, player.position.y, -20);
        transform.position = newPosition;
    }
}
