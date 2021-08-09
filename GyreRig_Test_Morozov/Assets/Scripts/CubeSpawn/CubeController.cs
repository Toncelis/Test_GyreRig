using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;

    public void Launch (float speed, float distance)
    {
        myRigidbody.velocity = Vector3.forward * speed;
        Invoke("DestroyMe", distance / speed);
    }

    private void DestroyMe ()
    {
        Destroy(gameObject);
    }
}
