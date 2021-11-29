public struct DialogueLine
{
    public int ID;
    public string Text;
    public Characters Who;
    public Locations Where;
    public int Next;
    public int NextB;
    public string ChoiceA;
    public string ChoiceB;

    public DialogueLine(int id,string txt,int next,Characters who=Characters.SameAsBefore,Locations where=Locations.None)
    {
        ID = id;
        Text = txt;
        Who = who;
        Where = where;
        Next = next;
        NextB = 0;
        ChoiceA = "";
        ChoiceB = "";
    }
    
    public DialogueLine(int id,string txt,string choiceA,int nextA,string choiceB,int nextB,Characters who=Characters.SameAsBefore,Locations where=Locations.None)
    {
        ID = id;
        Text = txt;
        Who = who;
        Where = where;
        Next = nextA;
        NextB = nextB;
        ChoiceA = choiceA;
        ChoiceB = choiceB;
    }
}

public enum Characters
{
    SameAsBefore,
    Goblin,
    Kobold,
    None
}

public enum Locations
{
    None,
    Nightclub,
    Library
}