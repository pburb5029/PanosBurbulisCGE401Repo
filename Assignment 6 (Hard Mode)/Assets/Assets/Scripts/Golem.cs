using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;

        scoreManager = FindObjectOfType<ScoreManager>();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.score += 2;
        }
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks!");
    }

    public override void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("You took " + amount + " points of damage!");

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Golem has died!");

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
