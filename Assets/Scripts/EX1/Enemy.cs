using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string nome;
    private int salute;
    public int livello;

    public Enemy(string nome, int salute, int livello)
    {
        this.nome = nome;
        SetSalute(salute);
        this.livello = livello;
    }

    public int GetSalute()
    {
        return salute;
    }

    public void SetSalute(int valore)
    { 
        if (valore < 0)
        {
            salute = 0;
        }
        else
        {
            salute = valore;
        }
    }

    public void SubisciDanno(int danno)
    {
        salute -= danno;

        if (salute < 0)
            salute = 0;


        if (salute == 0)
        {
            Debug.Log("Il nemico " + nome + " è stato sconfitto!");
        }
    }

    public bool IsMorto()
    {
        return salute <= 0;
    }
}
