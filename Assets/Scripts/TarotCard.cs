using UnityEngine;

[CreateAssetMenu(fileName = "New Tarot Card", menuName = "PixelTarot/Tarot Card")]
public class TarotCard : ScriptableObject
{
    public string cardName;
    public Sprite frontImage;
}
