using System.Threading.Tasks;
using ApplicationApp.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web_ECommerce.Controllers
{

    [Authorize]
    [LogActionFilter]
    public class ProdutoAPIController : BaseController
    {

        public readonly InterfaceProductApp _InterfaceProductApp;
        public readonly InterfaceCompraUsuarioApp _InterfaceCompraUsuarioApp;


        public ProdutoAPIController(InterfaceProductApp interfaceProductApp, UserManager<ApplicationUser> userManager, 
            InterfaceCompraUsuarioApp interfaceCompraUsuarioApp, ILogger<ProdutoAPIController> logger, InterfaceLogSistemaApp InterfaceLogSistemaApp)
            : base(logger, userManager, InterfaceLogSistemaApp)
        {
            _InterfaceProductApp = interfaceProductApp;
            _InterfaceCompraUsuarioApp = interfaceCompraUsuarioApp;
        }


        [HttpGet("/api/ListaProdutos")]
        public async Task<JsonResult> ListaProdutos(string descricao)
        {
            return Json(await _InterfaceProductApp.ListarProdutosComEstoque(descricao));
        }

    }
}
