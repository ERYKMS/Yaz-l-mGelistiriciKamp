using Business.Abstract;
using Business.CCS;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        Iloger _logger;

        public ProductManager(IProductDal productDal,Iloger loger)
        {
            _productDal = productDal;
            _logger = loger;
        }
        
            
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            if (CheckIfProductCountOfCategoryCorrect(product.CategoryId).Succes && CheckIfProductName(product.ProductName).Succes)
            {
                _productDal.Add(product);

                return new SuccesResult(Messages.ProductAdded);
            }
            
            return new ErrorResult();

        }

        public IDataResult<List<Product>> GetAll()
        {
            //if (datetime.now.hour == 23)
            //{
            //    return new errordataresult<list<product>>(messages.maintenancetime);
            //}
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId == id));
        }

        public IDataResult<Product> GetByID(int id)
        {
            return new SuccesDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p=> p.UnitPrice <= max && p.UnitPrice>= min));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccesDataResult<List<ProductDetailDto>>(_productDal.GetProductDetail());

        }

        public List<ProductDetailDto> GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;

            if (result >= 15)
            {

                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccesResult(Messages.ProductAdded);
        }
        private IResult CheckIfProductName(string name)
        {
            var result=_productDal.GetAll(p => p.ProductName == name).Count;
            if(result == 0)
            {
                return new SuccesResult(Messages.ProductAdded);
            }
            return new ErrorResult();
        }
    }
}
