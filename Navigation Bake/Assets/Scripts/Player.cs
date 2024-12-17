using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private void Update()
    {
        // Detecta si se ha presionado el bot�n izquierdo del rat�n
        if (Input.GetButtonDown("Fire1"))
        {
            // Crea un rayo desde la c�mara principal hacia la posici�n del rat�n
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            // Realiza un raycast y verifica si ha golpeado algo
            if (Physics.Raycast(ray, out hit, 1000))
            {
                // Establece el destino del agente de navegaci�n al punto donde golpe� el rayo
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }
    }
}
