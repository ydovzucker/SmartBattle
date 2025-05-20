class BattleRobot : IPowerable, IMovable, IAttackable
{
    public bool IsOn { get; }
    public void MoveTo(string location)
    {

    }
    public void TurnOn() {
    }
    public void TurnOff()
{

}
    public void TakeDamage(int amount)
    {

    }
    public int Health { get; }


    public void Heal(int amount)
    {

    }
}