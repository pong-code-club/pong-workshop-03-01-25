using UnityEngine;

public class CharacterClassScript : MonoBehaviour
{
    public bool IsButtonPressed;
    public float CharacterSpeed;
    public string CurrentMovementDirection;
    public float score;
    public float HealthPower;
    public float AttackPower;
    public float AttackRange;
    public string CharacterName;
    public int CoinCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            TakeDamage();
        }
        if (collision.gameObject.name == "Coin")
        {
            CollectCoin();
        }
    }

    void TakeDamage()
    {
        HealthPower = HealthPower - 10;
    }

    void CollectCoin()
    {
        CoinCount = CoinCount + 1;
    }

    void Attack()
    {

    }

    void ChargeAttack()
    {

    }
}
