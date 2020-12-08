using Domain.Interfaces.Generics;
using Entities.Entities;
using Entities.Entities.Enums;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceUsuario
{
    public interface IUsuario : IGeneric<ApplicationUser>
    {
        Task<ApplicationUser> ObterUsuarioPeloID(string userID);

        Task AtualizarTipoUsuario(string userID, TipoUsuario tipoUsuario);
    }
}
