using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.transform.position = new Vector3(50, 10, 10);
    }
}
