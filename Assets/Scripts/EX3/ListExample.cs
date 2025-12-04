using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    [SerializeField] private int numeroMax;

    private List<int> numeri = new List<int>();
    void Start()
    {
        for (int i = 0; i <= numeroMax; i++)
        {
            int posizione = i % 3; // 0 = inizio, 1 = fine, 2 = metà

            if (posizione == 0)
            {
                // Inserisci all'inizio
                numeri.Insert(0, i);
            }
            else if (posizione == 1)
            {
                // Inserisci alla fine
                numeri.Add(i);
            }
            else
            {
                // Inserisci a metà
                int indexMedio = numeri.Count / 2;
                numeri.Insert(indexMedio, i);
            }

            // Stampo la lista dopo l'inserimento
            Debug.Log("Contenuto lista: " + ListaInStringa());
        }
    }

    private string ListaInStringa()
    {
        string risultato = "[ ";

        foreach (int n in numeri)
        {
            risultato += n + " ";
        }

        risultato += "]";

        return risultato;
    }
}
