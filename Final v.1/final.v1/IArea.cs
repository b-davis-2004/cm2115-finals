namespace final.v1;

public interface IArea
{
    string Name { get; }
    string Description { get; }
    IConflict Conflict { get; set; }

    void Enter(Player player);
}
