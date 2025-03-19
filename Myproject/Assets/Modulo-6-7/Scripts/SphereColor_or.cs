using UnityEngine;

/// <summary>
/// Cambia el color de la esfera de manera aleatoria en el método Awake.
/// </summary>
public class SphereColor_or : MonoBehaviour
{
    /// <summary>
    /// Referencia al script CubeColorChanger.
    /// </summary>
    public CubeColorChanger cubeColorChanger;

    /// <summary>
    /// Referencia al script CapsuleColorChanger.
    /// </summary>
    public CapsuleColorChanger capsuleColorChanger;

    /// <summary>
    /// Variable booleana que depende del resultado de un AND entre las variables de CubeColorChanger y CapsuleColorChanger.
    /// </summary>
    private bool isBothWhite;

    void Awake()
    {
        ChangeColor();
    }

    /// <summary>
    /// Cambia el color del objeto a un color aleatorio.
    /// </summary>
    void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = randomColor;
    }

    void Update()
    {
        if (cubeColorChanger != null || capsuleColorChanger != null)
        {
            bool cubeIsWhite = cubeColorChanger.isWhite;
            bool capsuleIsWhite = capsuleColorChanger.isWhite;

            // La nueva variable booleana depende del resultado de un AND entre cubeIsWhite y capsuleIsWhite
            isBothWhite = cubeIsWhite || capsuleIsWhite;

            // Cambia el color de la esfera dependiendo del valor de isBothWhite
            Color newColor = isBothWhite ? Color.green : Color.red;
            GetComponent<MeshRenderer>().material.color = newColor;

            Debug.Log($"Cube is white: {cubeIsWhite}, Capsule is white: {capsuleIsWhite}, Both are white: {isBothWhite}");
        }
    }
}
