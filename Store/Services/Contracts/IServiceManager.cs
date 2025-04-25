namespace Services.Contracts
{
    public interface IServiceManager{
        IProductService ProductService { get; }
        ICategoryService categoryService{ get; }
    }
    
}