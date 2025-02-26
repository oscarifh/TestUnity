using UnityEngine;

/// <summary>
/// Cambia el color del cubo de manera aleatoria en el método Update.
/// </summary>
public class CubeColorChanger : MonoBehaviour
{
    void Update()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = randomColor;
    }

    /// <summary>
    /// Cambia el color del objeto a un color aleatorio.
    /// </summary>

}
