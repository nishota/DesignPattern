namespace DesignPattern.ValueObject;

public class Dollar
{
    public double Ammount { get; init; }

    public Dollar(double ammount)
    {
        Ammount = ammount;
    }
    public Dollar(string ammount)
    {
        if (!double.TryParse(ammount, out double result))
            throw new ArgumentException();
        Ammount = result;
    }

    public Dollar Add(Dollar doller)
    {
        return new Dollar(Ammount+doller.Ammount);
    }

    public Dollar Times(double multiplier)
    {
        return new Dollar(Ammount * multiplier);
    }

    public Dollar Times(string multiplier)
    {
        if (!double.TryParse(multiplier, out double result))
            throw new ArgumentException();
        return new Dollar(Ammount * result);
    }
}