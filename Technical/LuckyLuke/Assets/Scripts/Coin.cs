using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 targetPos;
    public Vector2 moveVector2;

	// Use this for initialization
	void Start ()
	{
	   moveVector2 = new Vector2(1*moveSpeed, 0*moveSpeed);
	}

    void Update()
    {
        Despawn();
    }

    //void FixedUpdate()
    //{
    //    rigidbody2D.velocity = moveVector2;
    //}

    void Despawn()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed);
        if (transform.position == targetPos)
        {
            PoolObject.DespawnCoin(gameObject);
        }
    }
}