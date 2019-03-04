namespace ViewComponentsTest.Models.ViewComponents
{
    public class ElementWidths
    {
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }

        public ElementWidths(int small, int medium, int large)
        {
            this.Small = small;
            this.Medium = medium;
            this.Large = large;
        }
    }
}
