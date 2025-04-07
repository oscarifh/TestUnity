using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EstructurasDatos : MonoBehaviour
{
    // Start is called before the first frame update

    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numerosAleatorios = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = Random.Range(rangoInferior, rangoSuperior);
            numerosAleatorios.Add(numeroAleatorio);
        }

        return numerosAleatorios;
    }

    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] arregloOrdenado = (int[])arreglo.Clone();
        System.Array.Sort(arregloOrdenado);
        System.Array.Reverse(arregloOrdenado);
        return arregloOrdenado;
    }

    public HashSet<T> EliminarDuplicados<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    public void TransferirPilaACola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        // Imprimir y transferir elementos de la pila a la cola
        Debug.Log("Contenido de la pila:");
        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log(elemento);
            cola.Enqueue(pila.Pop());
        }

        // Imprimir elementos de la cola
        Debug.Log("Contenido de la cola:");
        while (cola.Count > 0)
        {
            Debug.Log(cola.Dequeue());
        }
    }

    void Start()
    {
        // Ejemplo de uso de la función miFuncion
        List<int> resultado = miFuncion(10, 0, 100);
        Debug.Log("Lista de números aleatorios: " + string.Join(", ", resultado));

        // Ejemplo de uso de la función OrdenarDescendente
        int[] arreglo = { 5, 3, 8, 1, 2 };
        int[] arregloOrdenado = OrdenarDescendente(arreglo);
        Debug.Log("Arreglo ordenado de manera descendente: " + string.Join(", ", arregloOrdenado));

        // Ejemplo de uso de la función EliminarDuplicados
        List<int> listaConDuplicados = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> listaSinDuplicados = EliminarDuplicados(listaConDuplicados);
        Debug.Log("Lista sin duplicados: " + string.Join(", ", listaSinDuplicados));

        // Ejemplo de uso de la función TransferirPilaACola
        Stack<string> pila = new Stack<string>();
        pila.Push("uno");
        pila.Push("dos");
        pila.Push("tres");
        TransferirPilaACola(pila);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
