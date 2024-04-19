using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyController: MonoBehaviour
{
    private EnemyModel<int> model;

    public float movementSpeed = 10f;
    public float movementRange = 4f;
    public int enemyLevel;
    private float initialPositionX;

    public GameObject enemyPrefab;
    public SpawnControllerBase enemySpawner;

    private void Start()
    {
        Initialize(enemyLevel);

        if (enemySpawner == null)
        {
            enemySpawner = FindObjectOfType<SpawnControllerBase>(); // Busca el SpawnControllerBase en la escena
        }
    }

    public void Initialize(int enemyLvl)
    {
        model = new EnemyModel<int>(enemyLvl);
        initialPositionX = transform.position.x;
    }

    private void Update()
    {
        //Calcular movimiento de izquierda a derecha
        float offsetX = Mathf.Sin(Time.time * movementSpeed) * movementRange;

        //Actualizar posición del enemigo
        transform.position = new Vector3(initialPositionX + offsetX, transform.position.y, transform.position.z);
    }

    public void Defeated()
    {
        model.Defeated();
        Destroy(gameObject);
    }
}
