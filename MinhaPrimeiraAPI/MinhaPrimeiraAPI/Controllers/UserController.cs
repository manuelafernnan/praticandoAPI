using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet] //Usado para buscar algo na API
        public IEnumerable<UsuarioModel> Get()
        {
            List<UsuarioModel> usuárioModels = new List<UsuarioModel>(); //criação da variável

            usuárioModels.Add(new UsuarioModel() { Id = 1, Nome = "Manuela Fernandes", Email = "mm@gmail.com"});

            return usuárioModels;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")] //Usado para buscar algo na API com ID
        public UsuarioModel Get(int id)
        {
            UsuarioModel usuario = new UsuarioModel() { Id = 1, Nome = "Manuela Fernandes", Email = "mm@gmail.com" };

            return usuario;
        }

        // POST api/<UserController>
        [HttpPost] //Cadastrar 
        public void Post([FromBody] UsuarioModel dadosUsuario) //FromBody - os dados do usuario vai passar corpo dessa requisição
        {

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")] //Atualizar
        public void Put(int id, [FromBody] UsuarioModel atualizarUsuario)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
