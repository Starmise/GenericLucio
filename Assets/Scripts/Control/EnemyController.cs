using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController: MonoBehaviour
{

    private EnemyModel<int> model;

    public float movementSpeed = 10f;
    public float movementRange = 4f;
    public int enemyLevel;
    private float initialPositionX;

    private void Start()
    {
        Initialize(enemyLevel);
    }

    public void Initialize(int enemylvl)
    {
        model = new EnemyModel<int>(enemylvl);
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
