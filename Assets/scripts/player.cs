using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : AliveEntity
{
    // Construtor da classe Player
    private int level;
    private int experienceNeededForNextLevel;

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