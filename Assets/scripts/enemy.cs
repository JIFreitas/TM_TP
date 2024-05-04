using UnityEngine;

public class Enemy : AliveEntity
{
    public GameObject enemy;
    private GameObject player;
    public GameObject experiencePrefab;
    public GameObject coinPrefab;

    // Utilizado para o enemy ir atrás do player
    void Start(){
        player = GameObject.Find("Player");
    }

    void Update(){
        enemy.transform.Translate((player.transform.position - transform.position).normalized * base.speed * Time.deltaTime);
    }

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

    //override do método Die
    protected override void Die()
    {
        Vector3 small = new Vector3(0.2f, 0.2f, 0.2f);
        // Instancia o objeto de experiência
        GameObject xp = Instantiate(experiencePrefab, transform.position + small, Quaternion.identity);

        // Obtém o componente Experience do objeto de experiência
        Experience xpComponent = xp.GetComponent<Experience>();
        
        // Define a quantidade de experiência que o objeto de experiência concede
        xpComponent.experience = base.experience;

        // Instancia o objeto de experiência
        GameObject coin = Instantiate(coinPrefab, transform.position - small, Quaternion.identity);

        // Obtém o componente Experience do objeto de experiência
        Coin coinComponent = coin.GetComponent<Coin>();
        
        // Define a quantidade de experiência que o objeto de experiência concede
        coinComponent.coin = Random.Range(1, 10); // Número aleatório entre 1 e 9;

        // Chama o método Die da classe base
        base.Die();   
    }
}