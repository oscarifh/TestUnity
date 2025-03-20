using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    /// <summary>
    /// Variable de tipo entero que incrementa su valor en cada frame.
    /// </summary>
    private int frameCounter = 0;

    /// <summary>
    /// Variable de tipo float que se incrementa en cada FixedUpdate utilizando el operador *=.
    /// </summary>
    private float fixedUpdateMultiplier = 1.0f;

    /// <summary>
    /// Primera variable flotante.
    /// </summary>
    private float floatVar1 = 5.5f;

    /// <summary>
    /// Segunda variable flotante.
    /// </summary>
    private float floatVar2 = 2.3f;

    /// <summary>
    /// Resultado de la operación entre floatVar1 y floatVar2 convertido a entero.
    /// </summary>
    private int result;

    /// <summary>
    /// Prefab del cubo que se va a instanciar.
    /// </summary>
    public GameObject cubePrefab;

    /// <summary>
    /// Referencia al primer cubo instanciado.
    /// </summary>
    private GameObject cubeInstance1;

    /// <summary>
    /// Referencia al segundo cubo instanciado.
    /// </summary>
    private GameObject cubeInstance2;

    /// <summary>
    /// Variable de tipo string para determinar el color de los cubos.
    /// </summary>
    public string colorString = "red";

    /// <summary>
    /// Nueva variable flotante.
    /// </summary>
    private float newFloatVar = 123.456789f;

    /// <summary>
    /// Nombre completo.
    /// </summary>
    private string fullName = "Juan Carlos Pérez";

    // Start is called before the first frame update
    void Start()
    {
        // Realiza una operación entre floatVar1 y floatVar2 y convierte el resultado a entero
        result = (int)(floatVar1 + floatVar2);
        Debug.Log($"Resultado de la operación: {result}");

        // Convierte newFloatVar a string con 4 posiciones de precisión decimal
        string formattedFloat = newFloatVar.ToString("F4");
        Debug.Log($"Formatted Float: {formattedFloat}");

        // Utiliza Substring para separar el nombre completo en tres strings
        string firstName = fullName.Substring(0, 4); // "Juan"
        string middleName = fullName.Substring(5, 6); // "Carlos"
        string lastName = fullName.Substring(12); // "Pérez"

        Debug.Log($"First Name: {firstName}");
        Debug.Log($"Middle Name: {middleName}");
        Debug.Log($"Last Name: {lastName}");

        // Utiliza Split para separar el nombre completo en una lista de strings
        string[] nameParts = fullName.Split(' ');

        // Imprime la lista de strings
        foreach (string part in nameParts)
        {
            Debug.Log($"Name Part: {part}");
        }
        //////////////////////////////////////////PARTE 2//////////////////////////////////////////
        // 1) Crear dos variables string que guarden valores numéricos de miles, pasarlas a tipos de datos numéricos utilizando la función tryParse, realizar una operación con ellas e imprimir el resultado.
        string numString1 = "1000";
        string numString2 = "2000";
        int num1, num2;

        if (int.TryParse(numString1, out num1) && int.TryParse(numString2, out num2))
        {
            int sum = num1 + num2;
            Debug.Log($"La suma de {num1} y {num2} es: {sum}");
        }
        else
        {
            Debug.Log("Error al convertir las cadenas a números.");
        }

        // 2) Crear un string con una oración, imprimir sólo los caracteres que se encuentren en un índice par.
        string sentence = "Hola Mundo";
        string evenIndexChars = "";
        for (int i = 0; i < sentence.Length; i += 2)
        {
            evenIndexChars += sentence[i];
        }
        Debug.Log($"Caracteres en índices pares: {evenIndexChars}");

        // 3) Crear un string, guardar una oración en él y eliminar los primeros 5 caracteres de este.
        string longSentence = "Esta es una oración de ejemplo.";
        string modifiedSentence = longSentence.Substring(5);
        Debug.Log($"Oración modificada: {modifiedSentence}");
    }

    // Update is called once per frame
    void Update()
    {
        // Incrementa el valor de frameCounter en cada frame
        frameCounter++;
        Debug.Log($"Frame Counter: {frameCounter}");
    }

    // FixedUpdate is called at a fixed interval
    void FixedUpdate()
    {
        // Incrementa el valor de fixedUpdateMultiplier utilizando el operador *=
        fixedUpdateMultiplier *= 1.1f;
        Debug.Log($"Fixed Update Multiplier: {fixedUpdateMultiplier}");

        // Instancia los cubos si no existen
        if (cubeInstance1 == null && cubePrefab != null)
        {
            cubeInstance1 = Instantiate(cubePrefab);
        }

        if (cubeInstance2 == null && cubePrefab != null)
        {
            cubeInstance2 = Instantiate(cubePrefab);
        }

        // Cambia el color de los cubos dependiendo del valor de colorString
        if (cubeInstance1 != null && cubeInstance2 != null)
        {
            Color newColor;
            switch (colorString.ToLower())
            {
                case "red":
                    newColor = Color.red;
                    break;
                case "blue":
                    newColor = Color.blue;
                    break;
                case "green":
                    newColor = Color.green;
                    break;
                case "yellow":
                    newColor = Color.yellow;
                    break;
                default:
                    newColor = Color.white;
                    break;
            }

            cubeInstance1.GetComponent<MeshRenderer>().material.color = newColor;
            cubeInstance2.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }
}
