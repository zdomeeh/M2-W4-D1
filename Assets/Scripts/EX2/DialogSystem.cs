using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    public string dialogue;
    void Start()
    {
        // 1. Controllo formato base
        if (!dialogue.StartsWith("(") || !dialogue.Contains(")")) // Controllo formato base
        {
            Debug.LogError("Formato non valido! La stringa deve iniziare con '(' e contenere ')'.");
            return;
        }

        
        int closeIndex = dialogue.IndexOf(')'); // Trovo l'indice della parentesi chiusa

       
        string inside = dialogue.Substring(1, closeIndex - 1);  // Estraggo i valori dentro le ()

        
        string phrase = dialogue.Substring(closeIndex + 1).Trim(); // Estraggo la frase dopo la parentesi chiusa

        
        string[] tokens = inside.Split(';'); // Splitto i valori separati da ;

        
        foreach (string t in tokens) // Stampo i valori. Es:(aragorn, left, angry…)
        {
            Debug.Log("Valore: " + t.Trim());
        }

        
        Debug.Log("Frase: " + phrase); // Stampo la frase
    }
}
