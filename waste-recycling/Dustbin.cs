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
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage plasticGarbage = (PlasticGarbage)garbage;
                if (plasticGarbage.Cleaned)
                {
                    int newLength = PlasticContent.Length + 1;
                    PlasticContent = new PlasticGarbage[newLength];
                    PlasticContent[newLength-1] = plasticGarbage;
                    Console.WriteLine("plastic +1!");
                }
                else
                {
                    throw new DustbinContentException();
                }
            }
            else
            {
                if (garbage is PaperGarbage)
                {
                    PaperGarbage paperGarbage = (PaperGarbage)garbage;
                    if (paperGarbage.Squeezed)
                    {
                        int newLength = PaperContent.Length + 1;
                        PaperContent = new PaperGarbage[newLength];
                        PaperContent[newLength-1] = paperGarbage;
                        Console.WriteLine("paper +1!");
                    }
                    else
                    {
                        throw new DustbinContentException();
                    }
                }
                else
                {
                    if (garbage is Garbage)
                    {
                        int newLength = HouseWasteContent.Length + 1;
                        HouseWasteContent = new Garbage[newLength];
                        HouseWasteContent[newLength-1] = garbage;
                        Console.WriteLine("house +1!");
                    }
                    else
                    {
                        throw new DustbinContentException();
                    }
                }
            }

            
        }

        public void EmptyContents()
        {
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }
    }
}
