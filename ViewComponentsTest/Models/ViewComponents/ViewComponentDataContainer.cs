namespace ViewComponentsTest.Models.ViewComponents
{
    public class ViewComponentDataContainer<TData>
    {
        public TData Data { get; }

        public ViewComponentContainer ViewComponentContainer { get; }

        public ViewComponentDataContainer(ViewComponentContainer container, TData data)
        {
            this.Data = data;
            this.ViewComponentContainer = container;
        }
    }
}

