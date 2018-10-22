public class CardAttribute
{
    int baseValue = 0;
    int addN = 0; //additional value
    int addP = 0; //additional percent
    public int value { get { return (baseValue * (100 + addP) / 100) + addN; } }

    public CardAttribute(int b) { baseValue = b; }
    public void buffN(int n) { addN += n; }
    public void buffP(int p) { addP += p; }
}