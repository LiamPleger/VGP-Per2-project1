using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    //Alternate sprite to display after Wall has been attacked by player.
    public Sprite dmgSprite; 
    //hit points for the wall.
    public int hp = 4;


    //Store a component reference to the attached SpriteRenderer.
    private SpriteRenderer spriteRenderer;
    public AudioClip chopSound1;
    public AudioClip chopSound2;

    void Awake ()
    {
        //Get a component reference to the SpriteRenderer.
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }


    //DamageWall is called when the player attacks a wall.
    public void DamageWall (int loss)
    {
        SoundManager.instance.RandomizeSfx(chopSound1, chopSound2);
        //Set spriteRenderer to the damaged wall sprite.
        spriteRenderer.sprite = dmgSprite;

        //Subtract loss from hit point total.
        hp -= loss;

        //If hit points are less than or equal to zero:
        if(hp <= 0)
            //Disable the gameObject.
            gameObject.SetActive (false);
    }
}