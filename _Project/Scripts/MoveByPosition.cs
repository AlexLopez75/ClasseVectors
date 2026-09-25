using UnityEngine;

public class MoveByPosition : MonoBehaviour
{
    public int speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
    {
        Vector3 movement = new Vector3(speed, 0f, 0f);
        transform.position +=
        movement * Time.deltaTime;
    }
}
