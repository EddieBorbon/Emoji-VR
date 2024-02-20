using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public ParticleSystem[] explosionParticles; 
    public float force = 500f; // la fuerza aplicada al objeto
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hand"))
        {       
            // Calcular la dirección del golpe
            Vector3 direction = transform.position - other.transform.position;
            // Aplicar la fuerza en la dirección del golpe
            GetComponent<Rigidbody>().AddForce(direction.normalized * force);
            // Seleccionar un índice aleatorio para elegir una partícula
            int randomIndex = Random.Range(0, explosionParticles.Length);
            // Instanciar la partícula seleccionada
            Instantiate(explosionParticles[randomIndex], transform.position, explosionParticles[randomIndex].transform.rotation); 
        }
    }
}
