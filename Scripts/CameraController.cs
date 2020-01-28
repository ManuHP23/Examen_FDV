using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Variable publica para almacenar la referencia al gameObject player
    public GameObject player;
    //Variable privada para almacenar el offset entre el player y la MainCamera
    private Vector3 offset;

    void Start()
    {
        //Calcular y almacenar el valor del offset según la distancia entre la posición del player y la posición de la MainCamera
        offset = transform.position - player.transform.position;
    }
    // LateUpdate es llamdo despues del Update en cada frame
    void LateUpdate()
    {
        //Establecer la posición del transform de la MainCamera para que sea el mismo que el del player, pero el offset según el calculado.
        transform.position = player.transform.position + offset;
    }
}

