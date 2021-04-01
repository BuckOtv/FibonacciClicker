using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterSecs : MonoBehaviour
{
    //Float voor de aantal secondes voordat dit gameobject gedestroyed wordt.
    public float SecondsBeforeDeath;

    private void Awake()
    {
        //Destroyed dit gameobject na het aantal aangegeven seconden
        Destroy(gameObject, SecondsBeforeDeath);
    }
}
