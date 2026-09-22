using UnityEngine;

public class InteractSphere : MonoBehaviour
{
    public Color color_cube;
    public MeshRenderer mr;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        Debug.Log("Point added");
        mr.material.color = Color.green;
    }
    private void OnMouseUp()
    {
        mr.material.color = Color.white;
    }
}
