using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcomSpy.Domain.Models;

namespace EcomSpy.Domain.Aggregate
{
    public class ProductAggregate
    {
        private List<Product> _products = new();

        // Propriedade pública de leitura
        public IReadOnlyCollection<Product> Products { get; private set; }

        // Construtor que inicializa a propriedade Products
        public ProductAggregate()
        {
            Products = _products.AsReadOnly(); // Inicializando no construtor
        }

        // Método para adicionar um produto
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
