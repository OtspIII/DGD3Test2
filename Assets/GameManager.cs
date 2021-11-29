using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<int,DialogueLine> Dialogue = new Dictionary<int, DialogueLine>();
    public DialogueLine Current;
    public DialogueBoxController DBox;
    public PortraitController Portrait;
    public BGController BG;

    private void Awake()
    {
        BuildScript();
        SetLine(1);
    }

    void Update()
    {
        if (Current.NextB > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                SetLine(Current.Next);
            if (Input.GetKeyDown(KeyCode.Alpha2))
                SetLine(Current.NextB);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SetLine(Current.Next);
        }
    }

    public void SetLine(int line)
    {
        Current = Dialogue[line];
        DBox.Imprint(Current);
        BG.Imprint(Current);
        Portrait.Imprint(Current);
    }

    void BuildScript()
    {
        Add(new DialogueLine(1,"Funny meeting you here",2,Characters.Goblin,Locations.Nightclub));
        Add(new DialogueLine(2,"I'm Goblin, a goblin",3));
        Add(new DialogueLine(3,"Want to hang out at the library?","Go to the library",4,"Don't",5));
        Add(new DialogueLine(4,"We are at the library",8,Characters.Goblin,Locations.Library));
        Add(new DialogueLine(5,"Okay Bye",6));
        Add(new DialogueLine(6,"I'm Kobold",7,Characters.Kobold));
        Add(new DialogueLine(7,"Let's dance",8));
        Add(new DialogueLine(8,"You Win",1,Characters.None));
    }

    void Add(DialogueLine dl)
    {
        Dialogue.Add(dl.ID,dl);
    }
}
