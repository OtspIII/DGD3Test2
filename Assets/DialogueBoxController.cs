using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueBoxController : MonoBehaviour
{
    public TextMeshPro Dialogue;
    public TextMeshPro Speaker;
    
    public void Imprint(DialogueLine dl)
    {
        string sp = dl.Who.ToString();
        if (dl.Who == Characters.None)
            sp = "";
        string d = dl.Text;
        if (dl.NextB > 0)
        {
            d += "\n 1) " + dl.ChoiceA;
            d += "\n 2) " + dl.ChoiceB;
        }
        Dialogue.text = d;
        if (dl.Who != Characters.SameAsBefore)
            Speaker.text = sp;
    }
}
