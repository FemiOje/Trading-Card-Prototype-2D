using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Player name
    /// </summary>
    [SerializeField] private string _name;

    /// <summary>
    /// Is it this player's turn? 
    /// </summary>
    private bool _isActive;

    /// <summary>
    /// Player's health
    /// </summary>
    private int _health;

    /// <summary>
    /// Maximum health/points each player starts with - 100
    /// </summary>
    private readonly int _maxHealth = 100;


    void Start()
    {
        _health = _maxHealth;
    }
}
