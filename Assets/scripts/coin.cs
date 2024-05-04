using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coin;

    //Função para o xp seguir o player se ele passar perto
    void Update()
    {
        if(Vector3.Distance(transform.position, GameObject.Find("Player").transform.position) < 2f)
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").transform.position, 0.1f);

        if(Vector3.Distance(transform.position, GameObject.Find("Player").transform.position) < 0.5f)
        {
            GameObject.Find("Player").GetComponent<Player>().GainCoin(coin);
            Destroy(gameObject);
        }
    }
}
