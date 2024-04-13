using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab da bala
    public float bulletSpeed = 10f; // Velocidade da bala

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Verifica se o botão de disparo (normalmente o botão esquerdo do mouse) foi pressionado
        {
            Shoot(); // Dispara uma bala
        }
    }

    void Shoot()
    {
        // Obtém a posição do jogador
        Vector3 playerPos = transform.position;

        // Obtém a posição do cursor do mouse no plano XY do mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

        // Define explicitamente a posição Z da bala como 0
        mousePos.z = 0;

        // Calcula a direção da bala
        Vector3 direction = (mousePos - playerPos).normalized;

        // Instancia a bala na posição do jogador
        GameObject bullet = Instantiate(bulletPrefab, playerPos, Quaternion.identity);

        // Aplica velocidade à bala na direção do cursor do mouse
        bullet.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
    }

}
