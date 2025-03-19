using UnityEngine;

/// <summary>
/// Cambia el color de la cápsula de manera alternada entre blanco y negro en el método FixedUpdate.
/// </summary>
public class CapsuleColorChanger : MonoBehaviour
{
    /// <summary>
    /// Variable booleana que se alterna en cada FixedUpdate.
    /// </summary>
    public bool isWhite = false;

    void FixedUpdate()
    {
        // Alterna el valor de isWhite
        isWhite = !isWhite;

        // Cambia el color del objeto dependiendo del valor de isWhite
        Color newColor = isWhite ? Color.white : Color.black;
        GetComponent<MeshRenderer>().material.color = newColor;
    }
}
