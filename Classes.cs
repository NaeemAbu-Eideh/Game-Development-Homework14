using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Character
{
    private string name;
    private int health;

    public Character(string str = "Subhi", int number = 100)
    {
        setName(str);
        setHealth(number);
    }

    public void setName(string str) { name = str; }
    public void setHealth(int number)
    {
        if (number >= 0 && number <= 100)
        {
            health = number;
        }
        else
        {
            Debug.Log("Health must be between 0 and 100.");
        }
    }

    public string getName() { return name; }
    public int getHealth() { return health; }


}

class Player : Character {
    public Player(string name, int health) : base(name, health) { }
    public void Heal( int number) {
        if (getHealth() == 100)
        {
            Debug.Log($"the player {getName()} health is full, so we can't increase it");
        }
        else {
            int num = getHealth() + number;
            if (num > 100) num = 100;
            setHealth(num);
            Debug.Log($"the player {getName()} heal is increassed by healling and become {getHealth()} ");
        }
        
    }
}

class Enemy : Character {
    public Enemy(string name, int health) : base(name, health) { }
    public void Attack(Player player , int number) {
        if (getHealth() == 0)
        {
            Debug.Log($"the player {player.getName()} health is 0, so we can't dameaged  it");
        }
        else
        {
            int num = player.getHealth() - number;
            if (num < 0) num = 0;
            player.setHealth(num);
            Debug.Log($"the player {player.getName()} heal is decreassed by attacing and become {player.getHealth()} ");
        }
    }
}
