using System;

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
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }

        public void DisplayContents()
        {
            int houseWasteCount = HouseWasteContent.Length;
            int paperCount = PaperContent.Length;
            int plasticCount = PlasticContent.Length;

            Console.WriteLine($"{Color} dustbin!\n\nHouse waste content: {houseWasteCount} item(s)\n");
            foreach (Garbage garbage in HouseWasteContent)
            {
                Console.WriteLine($"\t{garbage.Name}");
            }

            Console.WriteLine($"\nPaper content: {paperCount} item(s)\n");
            foreach (PaperGarbage paperGarbage in PaperContent)
            {
                Console.WriteLine($"\t{paperGarbage.Name}");
            }

            Console.WriteLine($"\nPlastic content: {plasticCount} item(s)\n");
            foreach (PlasticGarbage plasticGarbage in PlasticContent)
            {
                Console.WriteLine($"\t{plasticGarbage.Name}");
            }
        }

        public void ThrowOutGarbage(Garbage garbage)
        {

        }
        
        public void EmptyContents()
        {
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }
    }
}
