using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodigoPrueba : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;// Obtengo la posición del mouse en coordenadas de pantalla

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Mathf.Abs(Camera.main.transform.position.z)));
        //Con este codigo convertimos la posicion del mouse de coordenadas de la pantalla de la scena

        transform.position = new Vector3(worldPos.x, transform.position.y, worldPos.z);
        // Con este codigo actualizamos la posición del objeto en los ejes x y z
    }
}
