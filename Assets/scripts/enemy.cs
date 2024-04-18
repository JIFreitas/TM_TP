using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : AliveEntity
{
     void OnCollisionEnter(Collision collision)
    {
        //Verifica se a colisão foi causada por um objeto com a tag "bullet"
        if (collision.gameObject.name == "bullet"){
            // Obtém o dano do objeto que causou a colisão
            float damage = collision.gameObject.GetComponent<Bullet>().damage;
            // Aplica o dano ao inimigo
            TakeDamage(damage);
            // Destroi a bala
            Destroy(collision.gameObject);
        }
    }
}
