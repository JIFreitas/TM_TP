using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected string entityName;
    protected string race;
    protected int health;
    protected int attackDamage;
    protected int defense;
    protected int speed;
    protected int mana;
    protected int stamina;
    protected int experience = 0;

    // Construtor da classe Entity
    public Entity(string entityName, string race, int health, int attackDamage, int defense, int speed, int mana, int stamina){
        this.entityName = entityName;
        this.race = race;
        this.health = health;
        this.attackDamage = attackDamage;
        this.defense = defense;
        this.speed = speed;
        this.mana = mana;
        this.stamina = stamina;
    }

    // Método para realizar um ataque
    public virtual void Attack(Entity target)
    {
        int damageDealt = Mathf.Max(0, attackDamage - target.defense);
        target.TakeDamage(damageDealt);
        Debug.Log($"{entityName} atacou {target.name} e causou {damageDealt} de dano!");
    }

    // Método para receber dano
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Método para adicionar XP à entidade
    public virtual void GainExperience(int amount)
    {
        experience += amount;
        Debug.Log($"{entityName} ganhou {amount} de experiência!");
        // Adicionar aqui qualquer lógica adicional quando a entidade ganha experiência
    }

    // Método chamado quando a entidade morre
    protected virtual void Die()
    {
        Debug.Log($"{entityName} morreu!");
    }
}
