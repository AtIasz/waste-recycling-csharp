namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent { get; set; }
        public PlasticGarbage[] PlasticContent { get; set; }
        public Garbage[] HouseWasteContent { get; set; }

        public Dustbin(string color)
        {
            this.Color = color;
            PaperContent = new PaperGarbage[100];
            PlasticContent = new PlasticGarbage[100];
            HouseWasteContent = new Garbage[100];
        }
    }
}
