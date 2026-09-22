using Unity.VisualScripting;
using UnityEngine;

public class InteractSphere : MonoBehaviour
{
    public Color color_cube;
    public MeshRenderer mr;
    private bool shouldAddScore = true;
    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        if (shouldAddScore) GameManager.Instance.AddScore(5);
        else GameManager.Instance.RemoveScore(5);
        Destroy(gameObject);
    }
    private void OnMouseEnter()
    {
        if (shouldAddScore)
        {
            mr.material.color = Color.green;
        }
        else
        {
            mr.material.color = Color.red;
        }
    }
    private void OnMouseExit()
    {
        mr.material.color = Color.white;
    }
    public void checkHazard()
    {
        shouldAddScore = !shouldAddScore;
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(other.CompareTag("HazardLine"))
        {
            checkHazard();
        }
    }
    private void OnMouseUp()
    {
        mr.material.color = Color.white;
    }
}
