using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;
public class ClickFibonacci : MonoBehaviour
{
    //De texten om te veranderen
    public TextMeshProUGUI text;
    public TextMeshProUGUI clicktext;

    //de ints om voor de Fibonacci reeks te gebruiken
    public long a = 0;
    public long b = 1;

    //de int voor het aantal button clicks.
    int clicks = 0;
    
    //De button
    Button button;

    //Pakt de PostProcessVolume om later te veranderen
    public PostProcessVolume volume;

    //Bloom voor PostProcessing
    private Bloom _bloom;

    //Particle Effect om te gebruiken bij het klikken van het nummer
    [SerializeField] public GameObject ParticleEffect;

    //De AudioSources om te gebruiken bij clicks of aantal kliks
    public AudioSource victory;
    public AudioSource heaven;
    public AudioSource click;
    public AudioSource ding;
    public AudioSource ducky;
    public AudioSource monsterkill;

    private void Start()
    {
        //Haalt de button op en probeert de Bloom uit de volume te pakken
        button = GetComponent<Button>();
        volume.profile.TryGetSettings(out _bloom);
    }
    public void OnClickFibonacci()
    {
        //Creeërt het particle effect op de plek van dit gameobject (de button)
        Instantiate(ParticleEffect, transform.position, transform.rotation);

        //Een random int om te kijken of je de normale klik geluid afspeelt of een badeend geluid. :3
        int duckornot = Random.Range(1, 300);
        if(duckornot < 298)
        {
            click.Play();
        } else
        {
            ducky.Play();
        }

        //De Fibonacci Reeks
        for (int i = 0; i < 1; i++)
        {
            long temp = a;
            a = b;
            b = temp + b;
        }

        Debug.Log(a + b);
        /////
        
        //Zet het opgetelde getal om naar string en de text van het getal van de button wordt dat opgetelde getal
        text.text = b.ToString();

        //Zet de button's interactivity uit en aan
        button.interactable = false;
        button.interactable = true;

        //clicks +1 en zet het om naar de text (van de aantal kliks)
        clicks++;
        clicktext.text = clicks.ToString();


        /////////////////////////
        
        //Hieronder is het elke keer hetzelfde principe
        //Elke keer dat het aantal kliks een getal bereikt, wordt de Bloom van de PostProcessing aangepast en een geluid afgespeelt
        if(clicks == 25)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color32(0, 209, 255, 255);
            _bloom.color.Override(colorParameter);
            ding.Play();
        }

        if (clicks == 50)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = Color.yellow;
            _bloom.color.Override(colorParameter);
            ding.Play();
        }

        if (clicks == 100)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = Color.magenta;
            _bloom.color.Override(colorParameter);
            ding.Play();
        }
        
        if (clicks == 250)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = Color.green;
            _bloom.color.Override(colorParameter);
            ding.Play();
        }

        if (clicks == 500)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color32(255, 16, 0, 255);
            _bloom.color.Override(colorParameter);
            monsterkill.Play();
        }

        if (clicks == 1000)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color32(84, 57, 255, 255);
            _bloom.color.Override(colorParameter);
            victory.Play();
        }

        if (clicks == 2500)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color32(0, 209, 255, 255);
            _bloom.color.Override(colorParameter);
            ding.Play();
        }


        if (clicks == 5000)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = Color.yellow;
            _bloom.color.Override(colorParameter);
            ding.Play();
        }

        if (clicks == 7500)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = Color.green;
            _bloom.color.Override(colorParameter);
            ding.Play();
        }

        if (clicks == 10000)
        {
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color32(255, 255, 255, 255);
            _bloom.color.Override(colorParameter);
            heaven.Play();
        }
    }


}
