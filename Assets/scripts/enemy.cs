using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : AliveEntity
{
    public GameObject enemy;
    private GameObject player;


    // Utilizado para o enemy ir atrás do player
    void Start(){
        player = GameObject.Find("Player");
    }

    void Update(){
        enemy.transform.Translate((player.transform.position - transform.position).normalized * base.speed * Time.deltaTime);
    }

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
