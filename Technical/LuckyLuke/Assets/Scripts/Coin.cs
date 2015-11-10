using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 targetPos;

	// Use this for initialization
	void Start ()
	{
	   
	}
	
	// Update is called once per frame
	void Update () {
	    Move();
	}

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed);
        if (transform.position == targetPos)
        {
            PoolObject.DespawnCoin(gameObject);
        }
    }
}