using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _anim;
    public Vector2 force;
    public bool isJump = false;
    public GameObject coinTarget;
    
	// Use this for initialization
	void Start ()
	{
	    _rigidbody2D = GetComponent<Rigidbody2D>();
	    _anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    [ContextMenu("jump")]
    public void Jump()
    {
        if (!isJump)
        {
            isJump = true;
            _anim.enabled = false;
            _rigidbody2D.AddForce(force);
        }
    }

    void OnCollisionEnter2D()
    {
        isJump = false;
        _anim.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == coinTarget.tag)
        {
            PoolObject.DespawnCoin(other.gameObject);
        }
    }
}
