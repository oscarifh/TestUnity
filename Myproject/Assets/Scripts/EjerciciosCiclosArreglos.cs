using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(0, 100);
            arr2[i] = Random.Range(0, 100);
            arr3[i] = arr1[i] + arr2[i];
        }

        // Imprimir los arreglos para verificar los resultados
        Debug.Log("Arreglo 1: " + string.Join(", ", arr1));
        Debug.Log("Arreglo 2: " + string.Join(", ", arr2));
        Debug.Log("Arreglo 3: " + string.Join(", ", arr3));

        // Crear y llenar el arreglo de strings
        string[] palabras = { "Esta", "es", "una", "oración", "de", "ejemplo." };

        // Concatenar los elementos del arreglo usando un ciclo foreach
        string oracionCompleta = "";
        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + " ";
        }

        // Imprimir la oración completa en la consola
        Debug.Log("Oración completa: " + oracionCompleta.Trim());

        // Crear y llenar el arreglo bidimensional
        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        // Crear y llenar el arreglo unidimensional
        int[] vector = new int[2] { 2, 3 };

        // Crear el arreglo resultado
        int[] resultado = new int[3];

        // Multiplicar la matriz por el vector
        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            resultado[i] = 0;
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                resultado[i] += matriz[j, i] * vector[j];
            }
        }

        // Imprimir el resultado de la multiplicación
        Debug.Log("Resultado de la multiplicación matriz * vector: " + string.Join(", ", resultado));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
