using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : AliveEntity
{
     void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão foi com um objeto que causa dano
        Debug.Log("Colisão com objeto que causa dano");
        Debug.Log(collision);
        // // Verifica se a colisão foi com um objeto que causa dano
        // if (collision.gameObject.CompareTag("bullet"))
        // {
        //     // Obtém o dano do objeto que causou a colisão
        //     float damage = collision.gameObject.GetComponent<Bullet>().damage;
        //     // Aplica o dano ao inimigo
        //     TakeDamage(damage);
        // }
    }
}
