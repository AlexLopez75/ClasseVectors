using UnityEngine;

public class DirectionTarget : MonoBehaviour
{
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = target.position - transform.position;
        Debug.DrawLine(transform.position, target.position);
        Debug.Log(direction.magnitude);
    }
}
