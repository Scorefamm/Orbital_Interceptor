using UnityEngine;

public class TurretFollow : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            if(directionToTarget != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            float dotProduct = Vector3.Dot(transform.forward, directionToTarget);

            if (dotProduct > 0.95)
            {
                Debug.Log("TargetLocked");
            }
            else
            {
                Debug.Log("Searching");
            }
        }
        return;
    }
}
