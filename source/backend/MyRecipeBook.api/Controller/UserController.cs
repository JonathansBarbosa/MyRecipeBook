using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Requests.Responses;

namespace MyRecipeBook.api.Controller
{
    [Route("[controller]")] //Removido "api/" para não ficar repetindo 
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost] //método acionado quando um cliente envia uma requisição HTTP POST para o caminho associado ao endpoint.
        [ProducesResponseType(typeof(ResponsesRegisterUserJson), StatusCodes.Status201Created)] //retorna no swagger 201 e não 200
        public IActionResult Register(RequestRegisterUserJson request) // retorna nome,email,passowrld
                                        //O tipo IActionResult representa o resultado de uma ação em um controlador
        {
            return Created(); //Cria a entidade usuario 
        }
    }
}
