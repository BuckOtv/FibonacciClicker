using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    //Het script aangeven om iets uit te veranderen
    public ClickFibonacci fab;

    //Twee audiosources om de clips er uit af te spelen
    public AudioSource nope;
    public AudioSource denied;

    public void onclick()
    {
        //a en b uit de ClickFibonacci script worden gereset naar 0 en 1, en de text wordt weer terug gezet naar 0
        fab.a = 0;
        fab.b = 1;
        fab.text.text = fab.a.ToString();

        //Een willekeurig getal tussen de 1 en de 3, vanuit daar wordt een geluid afgespeelt als het 1 is of een ander getal
        int random = Random.Range(1, 3);
        if (random == 1)
        {
            denied.Play();
        }
        else
        {
            nope.Play();

        }
    }
}
