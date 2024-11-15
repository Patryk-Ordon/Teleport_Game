public class Clock : PickUp
{
    public bool addTime; //true dodaje, false odejmuje czas
    public uint time = 5;
    public override void Picked()
    {
        int sign;
        if (addTime)
        {
            sign = 1;
        }
        else
        {
            sign = -1;
        }
        GameManager.gameManager.AddTime((int)time * sign);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}