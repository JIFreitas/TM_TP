using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AliveEntity : MonoBehaviour
{
    public string entityName;
    public string race;
    public int health;
    public int attackDamage;
    public float firerate;
    public int defense;
    public int speed;
    public int mana;
    public int stamina;
    public int experience = 0;

    // Método para adicionar XP à entidade
    public virtual void GainExperience(int amount)
    {
        experience += amount;
        Debug.Log($"{entityName} ganhou {amount} de experiência!");
        // Adicionar aqui qualquer lógica adicional quando a entidade ganha experiência
    }
    // Método para realizar um ataque
    public virtual void Attack(AliveEntity target)
    {
        int damageDealt = Mathf.Max(0, attackDamage - target.defense);
        target.TakeDamage(damageDealt);
        Debug.Log($"{entityName} atacou {target.name} e causou {damageDealt} de dano!");
    }

    // Método para receber dano
    public virtual void TakeDamage(float damage)
    {
        Debug.Log($"{entityName} recebeu {damage} de dano!");
        health -= Mathf.RoundToInt(damage);
        if (health <= 0)
        {
            Die();
        }
    }

    // Método chamado quando a entidade morre
    protected virtual void Die()
    {
        Debug.Log($"{entityName} morreu!");
        Destroy(gameObject);
    }
}
