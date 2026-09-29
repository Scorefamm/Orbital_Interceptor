using UnityEngine;

public class Grunt : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxHealth = 40f;
        currentHealth = maxHealth;
        moveSpeed = 4;
    }
    public override void PerformAttack()
    {
        Debug.Log("I perform BASH attack");
    }
}
