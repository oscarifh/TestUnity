using UnityEngine;

/// <summary>
/// Cambia el color de la esfera de manera aleatoria en el método Awake.
/// </summary>
public class SphereColorChanger : MonoBehaviour
{
    void Awake()
    {       
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = randomColor;
    }

    /// <summary>
    /// Cambia el color del objeto a un color aleatorio.
    /// </summary>

}
