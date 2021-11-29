using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitController : MonoBehaviour
{
    public SpriteRenderer SR;
    
    public Sprite Goblin;
    public Sprite Kobold;

    public void Imprint(DialogueLine dl)
    {
        if (dl.Who == Characters.Goblin)
            SR.sprite = Goblin;
        if (dl.Who == Characters.Kobold)
            SR.sprite = Kobold;
        if (dl.Who == Characters.None)
            SR.sprite = null;
    }
}
