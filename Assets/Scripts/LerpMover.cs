using UnityEngine;

public class LerpMover : MonoBehaviour
{
    public Transform pointA, pointB;
    public float travelDuration;

    private float timer;
    private bool toB = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float t = timer / travelDuration;

        //Vector3 start, target;
        //if (toB)
        //{
        //    start = pointA.position;
        //    target = pointB.position;
        //}
        //else
        //{
        //    start = pointB.position;
        //    target = pointA.position;
        //}

        Vector3 start = toB ? pointA.position : pointB.position;
        Vector3 target = toB ? pointB.position : pointA.position;

        transform.position = Vector3.Lerp(start, target, t);

        if(t > 1f)
        {
            timer = 0;
            //toB = false;
            toB = !toB;
        }
    }
}
