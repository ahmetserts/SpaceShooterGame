using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipCollider : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GameZone"))
        {
            Destroy(obj);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyLazer"))
        {
            Destroy(obj);
        }
        if (other.gameObject.CompareTag("Meteor"))
        {
            Destroy(obj);
        }
        if (other.gameObject.CompareTag("Sun"))
        {
            Destroy(obj);
        }
    }
}
