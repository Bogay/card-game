
public class Buffable
{
    int baseValue = 0;
    int addN = 0; //additional value
    int addP = 0; //additional percent

    public Buffable(int b)
    {
        baseValue = b;
    }

    public void buffN(int n)
    {
        addN += n;
    }

    public void buffP(int p)
    {
        addP += p;
    }

    public int getValue()
    {
        return (baseValue * (100 + addP) / 100) + addN;
    }
}