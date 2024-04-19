using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnControllerBase : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float interval = 4f;
    public float spawnRange = 10f;
    private float spawnTimer = 0f;

    protected virtual void Update()
    {
        // Contador para el spawn de los enemigos
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= interval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    protected virtual void SpawnEnemy()
    {
        //Generar un enemigo en una posición aleatoria
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0f, Random.Range(-spawnRange, spawnRange));
        GameObject enemy = GameObject.Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        EnemyController enemyController = enemy.GetComponent<EnemyController>();
        if (enemyController != null)
        {
            // Inicializar el EnemyController con algún nivel o parámetro genérico
            enemyController.Initialize(Random.Range(1, 5));
        }
    }
}

public class SpawnController<T> : SpawnControllerBase where T : EnemyController
{
    protected override void Update()
    {
        // Aquí puedes agregar funcionalidades específicas del SpawnController<T> si es necesario
        base.Update();
    }

    protected override void SpawnEnemy()
    {
        // Aquí puedes agregar funcionalidades específicas del SpawnController<T> si es necesario
        base.SpawnEnemy();
    }
}

