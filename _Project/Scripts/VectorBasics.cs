using UnityEngine;

public class VectorBasics : MonoBehaviour
{
    public Vector2 startPosition = new Vector2(2, 1);
    public Vector2 myVector = new Vector2(3, 4);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPosition;
        Debug.Log(myVector.magnitude);
        Debug.Log(myVector.normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
