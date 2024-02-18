using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables_PickUp : MonoBehaviour
{
    public enum PickUp_Type
    {
        Life,
        Score,
        PowerUp
    }

    [SerializeField] PickUp_Type currentPickUp_Type;
    [SerializeField] float destroyTimer = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
