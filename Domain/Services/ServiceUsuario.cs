using Domain.Interfaces.InterfaceServices;
using Domain.Interfaces.InterfaceUsuario;
using Entities.Entities;
using Entities.Entities.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IUsuario _IUsuario;
        public ServiceUsuario(IUsuario iUsuario)
        {
            _IUsuario = iUsuario;
        }

        public async Task<List<ApplicationUser>> ListarUsuarioSomenteParaAdministradores(string userID)
        {
            var usuario = await _IUsuario.ObterUsuarioPeloID(userID);

            return usuario != null && usuario.Tipo == TipoUsuario.Administrador ? await _IUsuario.List() : new List<ApplicationUser>();
        }
    }
}
