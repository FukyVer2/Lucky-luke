using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using PathologicalGames;

public class PoolObject : MonoBehaviour
{
    public static Transform SpawnObject(string poolName, GameObject obj, Vector3 pos)
    {
        SpawnPool pool = PoolManager.Pools[poolName];
        Transform gameObj = pool.Spawn(obj, pos, Quaternion.identity);
        return gameObj;
    }

    public static Transform SpawnCoin(GameObject obj, Vector3 pos, Vector3 target)
    {
        SpawnPool pool = PoolManager.Pools["Coin"];
        Transform gameObj = pool.Spawn(obj, pos, Quaternion.identity);

        //Enemy enemy = gameObj.gameObject.GetComponent<Enemy>();
        //if (enemy != null)
        //    enemy.speed = GameManager.Instance.speed;
        Coin coin = gameObj.GetComponent<Coin>();
        if (coin != null)
        {
            coin.targetPos = target;
        }

        return gameObj;
    }

    public static void DespawnCoin(GameObject obj)
    {
        SpawnPool pool = PoolManager.Pools["Coin"];
        pool.Despawn(obj.transform);
    }

    public static void DespawnObject(string poolName, GameObject obj)
    {
        SpawnPool pool = PoolManager.Pools[poolName];
        pool.Despawn(obj.transform);
    }

    public static void DespawnAll(string poolName)
    {
        SpawnPool pool = PoolManager.Pools[poolName];
        pool.DespawnAll();
    }
}
