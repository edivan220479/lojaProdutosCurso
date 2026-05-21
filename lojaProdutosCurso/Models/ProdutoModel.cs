using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace lojaProdutosCurso.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; } 
        public string Foto { get; set; }
        public double Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        // Chave estrangeira para CategoriaModel
        public int CategoriaModelId { get; set; }
        // Propriedade de navegação para CategoriaModel
        [ValidateNever]
        // Atributo para evitar validação durante a model binding
        public CategoriaModel Categoria { get; set; }

    }
}
