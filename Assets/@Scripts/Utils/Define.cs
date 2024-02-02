public class Define
{
    public enum Scene
    {
        Unknown,
        TitleScene,
        LobbyScene,
        GameScene,
    }

    public enum ObjectType
    {
        Player,
        Monster,
        Criminal,
        RaidMonster,
        Friend
    }

    public enum CreatureState
    {
        Idle,
        Moving,
        Attacking,
    }

    public enum UIEvent
    {
        Click,
        Pressed,
        PointerDown,
        PointerUp,
        Drag,
        BeginDrag,
        EndDrag,
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max,
    }
}
