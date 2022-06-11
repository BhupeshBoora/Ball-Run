using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnsfx : MonoBehaviour
{
    public AudioSource myFx;           //The audiosource that's on your player
    public AudioClip hoverFx;          //Audio that should play when you hover over your button
    public AudioClip clickFx;          //Audio that should play when you click on your button 

                                       //On your button in Unity, select the "HoverSound" and "ClickSound" functions accordingly 
    public void HoverSound()
    {
       myFx.PlayOneShot(hoverFx);          
    }
                                       //"PlayOneShot" makes sure the sound only plays once (each time you hover/click on your button)
    public void ClickSound()
    {
       myFx.PlayOneShot(clickFx);
    }

}
