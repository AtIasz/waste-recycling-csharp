namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin dustbin = new Dustbin("Red");

            PlasticGarbage plasticGarbage = new PlasticGarbage("plastic", true);
            dustbin.ThrowOutGarbage(plasticGarbage);
            PaperGarbage paperGarbage = new PaperGarbage("paper", true);
            dustbin.ThrowOutGarbage(paperGarbage);
            Garbage garbage = new Garbage("house");
            dustbin.ThrowOutGarbage(garbage);

            dustbin.DisplayContents();
        }
    }
}
