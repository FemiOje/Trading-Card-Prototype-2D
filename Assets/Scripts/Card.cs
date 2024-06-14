using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    /// <summary>
    /// Health points associated with this card
    /// </summary>
    [SerializeField] private int _hitPoints;

    /// <summary>
    /// Damage points associated with this card
    /// </summary>
    [SerializeField] private int _damagePoints;


    /// <summary>
    /// Is this card is in the playing deck?
    /// </summary>
    private bool isInDeck { get; set; }

    /// <summary>
    /// Is this card in the playing hand?
    /// </summary>
    private bool isInPlayingHand { get; set; }

    /// <summary>
    /// Is this card on the battlefield?
    /// </summary>
    private bool isInBattlefield { get; set; }


    /// <summary>
    /// Checks if this card is in the deck
    /// </summary>
    /// <returns>True is the card is in the deck, false otherwise</returns>
    public bool IsInDeck()
    {
        return isInDeck;
    }

    /// <summary>
    /// Checks if card is currrently part of the playing hand
    /// </summary>
    /// <returns>True if if card is currrently part of the playing hand, false otherwise</returns>
    public bool IsInPlayingHand()
    {
        return isInPlayingHand;
    }

    /// <summary>
    /// Checks if card is currrently in the battlefield
    /// </summary>
    /// <returns>True if card is currrently in the battlefield, false otherwise</returns>
    public bool IsInBattlefield()
    {
        return isInBattlefield;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
