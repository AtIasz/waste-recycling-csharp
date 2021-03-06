namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }

        public PlasticGarbage(string garbageName, bool cleaned) : base(garbageName)
        {
            this.Cleaned = cleaned;
        }

        public void Clean()
        {
            this.Cleaned = true;
        }
    }
}
