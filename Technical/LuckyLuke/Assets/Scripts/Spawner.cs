using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject coinObject;
    public Transform targetPos;
    public float delayTurn = 1f;
    public float delay = 0.1f;
    public int number = 3;

	void Update () {
	    Spawn();
	}

    void Spawn()
    {
        if (delayTurn > 0)
        {
            delayTurn -= Time.deltaTime;
        }
        else
        {
            if (delay>0)
            {
                delay -= Time.deltaTime;
            }
            else
            {
                if (number > 0)
                {
                    PoolObject.SpawnCoin(coinObject, transform.position, targetPos.position);
                    delay = 0.1f;
                    number --;
                }
                else
                {
                    number = 3;
                    delay = 0.1f;
                    delayTurn = 3f;
                }
            }
        }
    }
}
