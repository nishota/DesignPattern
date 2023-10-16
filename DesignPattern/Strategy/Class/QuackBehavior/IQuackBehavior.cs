namespace DesignPattern.Strategy;

/// <summary>
/// 鳴いたときのふるまい
/// </summary>
public interface IQuackBehavior
{
    /// <summary>
    /// 鳴く
    /// </summary>
    string Quack();
}
