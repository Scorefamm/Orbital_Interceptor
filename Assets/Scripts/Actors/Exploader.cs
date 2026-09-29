using JetBrains.Annotations;
using UnityEngine;

public class Exploader : Actor
{
    public float explosionRadius = 5f;
    public override void PerformAttack()
    {
        Explode();
    }
    public override void TakeDamage(float damageAmount)
    {
        base.TakeDamage(damageAmount);
    }

    private void Explode()
    {
        Debug.Log("BOOM");
        Destroy(gameObject);
    }
}
