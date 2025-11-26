using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{

    void Start()
    {
        Player p1 = new Player("Ciccio", 25);
        Player p2 = new Player("Monica", 70);

        Debug.Log(" Il giocatore " + p1.nome + " ha totalizzato " + p1.GetPunteggio() + " punti ");
        Debug.Log(" Il giocatore " + p2.nome + " ha totalizzato " + p2.GetPunteggio() + " punti ");

        Player p3 = new Player("Artemisio", 10);
        Debug.Log(" Il giocatore " + p3.nome + " ha totalizzato " + p3.GetPunteggio() + " punti ");

        p3.IncrementaPunteggio(100);
        Debug.Log(" Il giocatore " + p3.nome + " ha guadagnato un bonus ed arriva a " + p3.GetPunteggio() + " punti ");

        if (p3.IsVincitore())
        {
            Debug.Log(" Il giocatore " + p3.nome + " ha vinto la partita !");
        }
        else
        {
            Debug.Log(" Il giocatore " + p3.nome + " non ha ancora vinto la partita !");
        }

        Player p4 = new Player("Manila", -1000);
        Debug.Log(" Il giocatore " + p4.nome + " ha totalizzato " + p4.GetPunteggio() + " punti ");



        Enemy e1 = new Enemy("Scheletro", 50, 1);

        Debug.Log("È apparso un nemico! " + e1.nome + " (Livello " + e1.livello + ") con " + e1.GetSalute() + " salute.");

        void AttaccaEStampa(Player player, Enemy nemico, int danno)
        {
            player.AttaccaNemico(nemico, danno);

            if (!nemico.IsMorto())
            {
                Debug.Log("Il nemico " + nemico.nome + " ora ha " + nemico.GetSalute() + " salute rimanente.");
            }
        }


        AttaccaEStampa(p1, e1, 20);
        AttaccaEStampa(p2, e1, 40);
    }

    void Update()
    {

    }
}
        
