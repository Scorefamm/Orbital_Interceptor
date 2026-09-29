using UnityEngine;

//Abstract: prevents anyone from accidentally attacking this script to any object
public abstract class Actor : MonoBehaviour
{
    //Protected instead of private, this keeps the maxhealth hidden from unrelated outside scripts
    [Header("Base Actor Attributes")]
    [SerializeField] protected float maxHealth = 100f;
    protected float currentHealth;
    [SerializeField] protected float moveSpeed = 3f;

    //we mark awake as virtual:
    //ensured child classes can initialize their own awake.
    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    //Every enemy attacks differently, we declare this method as abstract
    public abstract void PerformAttack();
    //unlike attack we mark it as virtual so child classes can use standard health subtract formula.

    public virtual void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log($"{gameObject.name} took {damageAmount}");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} has died");
        Destroy(gameObject);
    }
}
