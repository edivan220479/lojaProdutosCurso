using lojaProdutosCurso.Data;
using lojaProdutosCurso.Dto.Produto;
using lojaProdutosCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace lojaProdutosCurso.Services.Produto
{
    public class ProdutoService : IProdutoInterface
    {
        // Injeção de dependência do banco de dados
        private readonly DataContext _context;
        private readonly string _sistema;
        public ProdutoService(DataContext context, IWebHostEnvironment sistema)
        {
            _context = context;
            _sistema = sistema.WebRootPath;
        }
        public async Task<List<ProdutoModel>> BuscarProdutos()
        {
            try
            {
                return await _context.Produtos.Include(c => c.Categoria).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProdutoModel> Cadastrar(CriarProdutoDto criarProdutoDto, IFormFile foto)
        {
            try
            {
                var nomeCaminhoImagem = GeraCaminhoArquivo(foto);
                var produto = new ProdutoModel 
                {
                    Nome = criarProdutoDto.Nome,
                    Marca = criarProdutoDto.Marca,
                    Valor = criarProdutoDto.Valor,
                    CategoriaModelId = criarProdutoDto.CategoriaModelId,
                    Foto = nomeCaminhoImagem,
                    QuantidadeEstoque = criarProdutoDto.QuantidadeEstoque
                };
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return produto;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        // Método para gerar um caminho único para a imagem do produto
        private string GeraCaminhoArquivo(IFormFile foto)
        {
            var codigoUnico = Guid.NewGuid().ToString();
            var nomeCaminhoImagem = foto.FileName.Replace(" ", "").ToLower() + codigoUnico + ".png";

            var CaminhoParaSalvarImagem = _sistema + "\\imagem\\";

            if (!Directory.Exists(CaminhoParaSalvarImagem))
            {
                Directory.CreateDirectory(CaminhoParaSalvarImagem);
            }
            using (var stream = File.Create(CaminhoParaSalvarImagem + nomeCaminhoImagem))
            {
                foto.CopyToAsync(stream).Wait();
            }
            return nomeCaminhoImagem;
        }
    }
}



