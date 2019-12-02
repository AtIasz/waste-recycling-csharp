namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; set; }
        public PaperGarbage(string garbageName, bool squeezed) : base(garbageName)
        {
            this.Squeezed = squeezed;
        }
    }
}
