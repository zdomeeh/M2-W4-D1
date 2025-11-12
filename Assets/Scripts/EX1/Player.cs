
using UnityEngine;



public class Player
{
    public string nome;
    private int punteggio;

    public Player(string nome, int punteggio)
    {
        this.nome = nome;
        SetPunteggio(punteggio);
    }

    public int GetPunteggio()
    {
        return punteggio;
    }

    public void SetPunteggio(int valore)
    {
        if (valore < 0)
        {
            punteggio = 0;
            Debug.LogWarning(nome + " ha ricevuto un punteggio negativo! Impostato automaticamente a 0.");
        }
    
        else
        {
            punteggio = valore;
        }
    }

    public void IncrementaPunteggio(int incremento)
    {
        punteggio += incremento;
    }

    public bool IsVincitore()
    {
        return punteggio >= 100;
    }
}
