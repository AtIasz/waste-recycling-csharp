public class GameMaster
{
    public string CharacterName { get; set; }
    private static GameMaster _instance = null;
    public static GameMaster Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameMaster();
            return _instance;
        }
    }

    private GameMaster() {}
}