using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wood")
        {
            Debug.Log("it is wood and added to inventory");

            // +1 on inventory

            // destroy the gameObject.tag == wood
            Destroy(collision.gameObject, 0.1f);
        }
        else if (collision.gameObject.tag == "plastic")
        {
            Debug.Log("it is plastic and added to inventory");

            // +1 on inventory

            // destroy the gameObject.tag == wood
            Destroy(collision.gameObject, 0.1f);
        }
        else if (collision.gameObject.tag == "metal")
        {
            Debug.Log("it is metal and added to inventory");

            // +1 on inventory

            // destroy the gameObject.tag == wood
            Destroy(collision.gameObject, 0.1f);
        }
        else if (collision.gameObject.tag == "glass")
        {
            Debug.Log("it is glass and added to inventory");

            // +1 on inventory

            // destroy the gameObject.tag == wood
            Destroy(collision.gameObject, 0.1f);
        }
    }
}
