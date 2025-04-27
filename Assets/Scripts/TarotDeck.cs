using UnityEngine;

[CreateAssetMenu(fileName = "Tarot Deck", menuName = "PixelTarot/Tarot Deck")]
public class TarotDeck : ScriptableObject
{
    public TarotCard[] cards;
}