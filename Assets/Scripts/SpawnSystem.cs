using System.Collections;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject EnemyPrefab;
    [SerializeField] Vector2 MinMaxValueX;
    [SerializeField] private float CooldownSpawn = 3;
    [SerializeField] private Transform Enemies;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(CooldownSpawn);
        GameObject Enemy = Instantiate(EnemyPrefab, Enemies);
        Enemy.transform.position = new Vector3(Random.Range(MinMaxValueX.x, MinMaxValueX.y),5.8f,-1);
        StartCoroutine(SpawnEnemy());
    }
}
