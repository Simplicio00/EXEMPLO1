using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tw.Models;
using Tw.Repositorio;
using TW.Repositorio;

namespace Tw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        UploadRepositorio uploadRepositorio = new UploadRepositorio();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        

        [HttpPut("up")]
        public async Task<ActionResult<Usuario>> Put([FromForm] Usuario usuario){
           
            
            try{
            var arquivo = Request.Form.Files[0];  
            usuario.ImagemUsuario = uploadRepositorio.Upload(arquivo,"UsuarioImagens");
            usuario.Email = Request.Form["email"];
            usuario.Senha = Request.Form["senha"];
            await usuarioRepositorio.Puto(usuario);
            }catch (System.Exception){
                throw;
            }
            return usuario;
        }






    }
}