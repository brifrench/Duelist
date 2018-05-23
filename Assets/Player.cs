using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int health = 100;

    


    private Hand[] left;
    private Hand[] right;


	// Use this for initialization
	void Start () {
        left = new Hand[2];
        right = new Hand[2];
	}
	
	// Update is called once per frame
	void Update () {
        if (health < 0)
        {
            destroyPlayer();
        }
    }

    public void dealDamage(int dmg)
    {
        health -= dmg;
        if (health < 0)
        {
            destroyPlayer();
        }
    }

    private void destroyPlayer()
    {
        //TODO remove player or end match
    }
}


public class Hand
{
    Spell[] left;
    Spell[] right;

    public Hand()
    {
        Spell[] left = new Spell[4];
        Spell[] right = new Spell[4];
    }


    public void createSpell(int element, int type, int location, int hand)
    {
        Spell temp;
        if( type == 0)
        {
            temp = new Shield(element);
        }
        else
        {
            temp = new Attack(element);
        }

        
        if(hand == 1)
        {
            left[location--] = temp;
        }
        else
        {
            right[location--] = temp;
        }


    }
}

public class Spell
{
    public int SpellElement;
    public int damage;
    
    public Spell()
    {

    }

    public Spell(int element, int type)
    {
        ///Element
        ///0 Neutral
        ///1 Fire
        ///2 Water
        ///3 Lightning
        ///4 Earth
        ///Type
        ///1 Attack
        ///2 Shield
        ///

        SpellElement = element;

        switch (element)
        {
            case 0:
                damage = 50;
                break;
            case 1:
                damage = 75;
                break;
            case 2:
                damage = 100;
                break;
            case 3:
                damage = 100;
                break;
            case 4:
                damage = 75;
                break;
            
        }

        switch (type)
        {
            case 2:
                damage *= -1;
                break;
            
        }
        
        
        

    }
}

public class Shield : Spell
{
    public Shield()
    {

    }

    public Shield(int element)
    {
        SpellElement = element;
        switch (element)
        {
            case 0:
                damage = 50;
                break;
            case 1:
                damage = 75;
                break;
            case 2:
                damage = 100;
                break;
            case 3:
                damage = 100;
                break;
            case 4:
                damage = 75;
                break;

        }

        damage *= -1;
    }
}

public class Attack : Spell
{

    public Attack()
    {

    }

    public Attack(int element)
    {
        SpellElement = element;
        switch (element)
        {
            case 0:
                damage = 50;
                break;
            case 1:
                damage = 75;
                break;
            case 2:
                damage = 100;
                break;
            case 3:
                damage = 100;
                break;
            case 4:
                damage = 75;
                break;

        }
    }
}


