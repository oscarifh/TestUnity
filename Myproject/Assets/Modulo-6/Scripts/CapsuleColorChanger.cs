using UnityEngine;

/// <summary>
/// Cambia el color de la c�psula de manera aleatoria en el m�todo FixedUpdate.
/// </summary>
public class CapsuleColorChanger : MonoBehaviour
{
    void FixedUpdate()

    {        
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = randomColor;
        
    }

    /// <summary>
    /// Cambia el color del objeto a un color aleatorio.
    /// </summary>
    
}
