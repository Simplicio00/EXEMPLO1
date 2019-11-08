using System.Threading.Tasks;
using Tw.Models;

namespace Tw.Interfaces
{
    public interface IUsuarioRepositorio
    {

         public Task<Usuario> Salvar(Usuario usuario);

         Task<Usuario> Puto(Usuario usuario);
         
    }
}