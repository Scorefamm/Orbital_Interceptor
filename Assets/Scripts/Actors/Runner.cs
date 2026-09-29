using UnityEngine;

public class Runner : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxHealth = 40f;
        currentHealth = maxHealth;
        moveSpeed = 10;
    }
    public override void PerformAttack()
    {
        Debug.Log("I run");
    }
}