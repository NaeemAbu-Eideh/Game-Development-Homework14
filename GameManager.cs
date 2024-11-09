using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Hero", 100);
        Enemy enemy = new Enemy("Villain", 100);

        Debug.Log($"Player: {player.getName()}, Health: {player.getHealth()}");
        Debug.Log($"Enemy: {enemy.getName()}, Health: {enemy.getHealth()}");

        player.Heal(10);

        enemy.Attack(player, 20);

        player.Heal(10);

    }
}
