using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Construtor da classe Player
    private int level;
    private int experienceNeededForNextLevel;
    public Player(string name, string race, int health, int attackDamage, int defense, int speed, int mana, int stamina) 
        : base(name, race, health, attackDamage, defense, speed, mana, stamina)
    {
        level = 1; // O jogador começa no nível 1
        experienceNeededForNextLevel = 100;
    }
    

    // Método para calcular o nível com base na experiência acumulada
    public void CalculateLevel()
    {
        this.level = Mathf.FloorToInt(Mathf.Sqrt(experience / experienceNeededForNextLevel) * this.level); // Exemplo simples: 1 nível a cada 100 de XP
    }

    // Método para ganhar experiência
    public override void GainExperience(int amount)
    {
        base.GainExperience(amount);
        CalculateLevel(); // Chama a função para recalcular o nível sempre que o jogador ganha experiência
    }
}