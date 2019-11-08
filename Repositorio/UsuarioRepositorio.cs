using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tw.Interfaces;
using Tw.Models;


namespace TW.Repositorio 
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

          TwContext context = new TwContext();


          public async Task<Usuario> Salvar(Usuario usuario)
        {
          await context.AddAsync(usuario);
          await context.SaveChangesAsync();
             return usuario;
        }

        public async Task<Usuario> Puto(Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return usuario;
        }


        
        
    }
}