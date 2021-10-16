using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{

    public static int countMoneda = 0;

    // Start is called before the first frame update
    void Start()
    {
        Moneda.countMoneda++;
    }

    void OnDestroy()
    {
        Moneda.countMoneda--;

        if (Moneda.countMoneda <= 0)
        {
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            Debug.Log("El juego ha terminado, has ganado!");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se ha recolectado la moneda #" + Moneda.countMoneda);
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
