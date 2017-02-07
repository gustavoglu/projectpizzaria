using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Project.Pizzaria.Application.ViewModels;
using Project.Pizzaria.Application.Interfaces;
using Project.Pizzaria.Application.Services;

namespace Project.Pizzaria.Presentation.WebApi.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController()
        {
            _produtoAppService = new ProdutoAppService();   
        }

        // GET: api/Produtos
        public IQueryable<ProdutoViewModel> GetProdutoViewModels()
        {
            return _produtoAppService.GetAllActives().AsQueryable();
        }

        // GET: api/Produtos/5
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult GetProdutoViewModel(Guid id)
        {
            ProdutoViewModel produtoViewModel = _produtoAppService.GetById(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return Ok(produtoViewModel);
        }

        // PUT: api/Produtos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProdutoViewModel(Guid id, Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produto_ProdutoTipoViewModel.ProdutoViewModel.Id)
            {
                return BadRequest();
            }
            try
            {

                _produtoAppService.Update(produto_ProdutoTipoViewModel);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoViewModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Produtos
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult PostProdutoViewModel(Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _produtoAppService.Add(produto_ProdutoTipoViewModel);

            }
            catch (DbUpdateException)
            {
                if (ProdutoViewModelExists(produto_ProdutoTipoViewModel.ProdutoViewModel.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = produto_ProdutoTipoViewModel.ProdutoViewModel.Id }, produto_ProdutoTipoViewModel);
        }

        private bool ProdutoViewModelExists(Guid id)
        {
            return _produtoAppService.GetById(id) == null ? false : true ;
        }

        // DELETE: api/Produtos/5
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult DeleteProdutoViewModel(Guid id)
        {
            ProdutoViewModel produtoViewModel = _produtoAppService.GetById(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            _produtoAppService.Remove(produtoViewModel);

            return Ok(produtoViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _produtoAppService.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}