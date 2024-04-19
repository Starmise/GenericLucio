using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float speedBoost;
    public float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                ItemModel<float> speedItem = new ItemModel<float>(speedBoost);
                player.ApplyItemEffect(speedItem, duration);

                Destroy(gameObject);
                Debug.Log("Lucio Recolectado");
            }
        }
    }
}
