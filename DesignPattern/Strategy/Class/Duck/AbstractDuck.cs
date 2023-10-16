namespace DesignPattern.Strategy;

public abstract class AbstractDuck
{
    private readonly IFlyBehavior _flyBehavior;
    private readonly IQuackBehavior _quackBehavior;

    protected AbstractDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        _flyBehavior = flyBehavior;
        _quackBehavior = quackBehavior;
    }

    /// <summary>
    /// 鴨の説明を出力する
    /// </summary>
    public abstract string Display();
    public string Fly()
    {
        return _flyBehavior.Fly();
    }
    public string Quack()
    {
        return _quackBehavior.Quack();
    }
}
