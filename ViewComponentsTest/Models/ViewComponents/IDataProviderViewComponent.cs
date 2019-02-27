namespace ViewComponentsTest.Models.ViewComponents
{
    public interface IDataProviderViewComponent<TDataProvided>
    {
        string DataProvidedTypeName { get; }
    }
}
