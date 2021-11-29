using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public SpriteRenderer SR;

    public Sprite Nightclub;
    public Sprite Library;
    
    public void Imprint(DialogueLine dl)
    {
        if (dl.Where == Locations.Nightclub)
            SR.sprite = Nightclub;
        if (dl.Where == Locations.Library)
            SR.sprite = Library;
    }
}
