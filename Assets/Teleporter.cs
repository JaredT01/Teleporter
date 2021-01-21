using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private Vector3 CurrentPosition;
    private CharacterController m_CharacterController;
    private void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Teleporter")
        {
            m_CharacterController.Move(new Vector3(0, 17, 50));
        }
        else if (other.tag == "Killbox")
        {
            CurrentPosition = (-m_CharacterController.transform.position) + new Vector3(0, 1, 0);
            m_CharacterController.GetComponent<CharacterController>().Move(CurrentPosition);
        }
    }
}
