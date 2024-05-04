using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MonoBehaviour
{
    public Player player;
    public GameObject bulletPrefab; // Prefab da bala
    public float bulletSpeed = 10f; // Velocidade da bala
    private float nextFire = 0.0f; // Tempo do próximo disparo
    
    // Define a distância entre o jogador e a bala
    public float bulletSpawnDistance = 1f; // Ajusta este valor conforme necessário

    void Update()
    {
       if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            // Atualiza o tempo do próximo disparo com base no firerate
            nextFire = Time.time + player.firerate;
            Shoot(player.attackDamage); // Dispara uma bala
        }
    }

    void Shoot(float playerDamage){
        // Obtém a posição do jogador
        Vector3 playerPos = transform.position;

        // Obtém a posição do cursor do mouse no plano XY do mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

        // Define explicitamente a posição Z da bala como 0
        mousePos.z = 0;

        // Calcula a direção da bala
        Vector3 direction = (mousePos - playerPos).normalized;

        // Calcula a posição inicial da bala à frente do jogador
        Vector3 bulletSpawnPos = playerPos + direction * bulletSpawnDistance;

        // Instancia a bala na posição inicial calculada
        GameObject bulletObject = Instantiate(bulletPrefab, bulletSpawnPos, Quaternion.identity);
        bulletObject.name = "bullet"; // Define o nome do objeto como "bullet"
        Bullet bulletComponent = bulletObject.GetComponent<Bullet>(); // Obtém o componente bullet da bala

        // Configura a velocidade e o dano da bala
        bulletComponent.speed = bulletSpeed;
        bulletComponent.damage = playerDamage;

        // Aplica velocidade à bala na direção do cursor do mouse
        bulletObject.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
    }
}
