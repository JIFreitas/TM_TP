using UnityEngine;

public class Player : AliveEntity
{
    // Construtor da classe Player
    public int level = 1;
    private int experienceNeededForNextLevel = 99;

    public int coin = 0;

    // Método para calcular o nível com base na experiência acumulada
    public void CalculateLevel()
    {
        int oldLevel = this.level;
        this.level = Mathf.FloorToInt(Mathf.Sqrt(experience / experienceNeededForNextLevel) * this.level); // Exemplo simples: 1 nível a cada 100 de XP
        int leveldif = this.level - oldLevel;
        if(leveldif != 0){
            Debug.Log("Player leveled up to level " + this.level);
            while(leveldif > 0){
                // Adiciona 1 ponto de vida e 1 ponto de ataque a cada nível
                Debug.Log("Player gained 1 point of health and 1 point of attack.");
                leveldif--;
            }
        }
    }

    // Método para ganhar experiência
    public override void GainExperience(int amount)
    {
        Debug.Log("Player gained " + amount + " experience points.");
        base.GainExperience(amount);
        CalculateLevel(); // Chama a função para recalcular o nível sempre que o jogador ganha experiência
    }

    public void GainCoin(int amount)
    {
        Debug.Log("Player gained " + amount + " coins.");
        this.coin += amount;
    }
}