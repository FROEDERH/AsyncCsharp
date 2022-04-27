using Microsoft.AspNetCore.Mvc;
using ProgramacaoAssincrona.ExternalServices;
using ProgramacaoAssincrona.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona.Controllers
{
    [ApiController]
    [Route("programacao_assincrona")]
    public class ProgramacaoAssincronaController : ControllerBase
    {
        private readonly IJsonPlaceHolderExternalService _jsonPlaceHolderExternalService;

        public ProgramacaoAssincronaController(IJsonPlaceHolderExternalService jsonPlaceHolderExternalService)
        {
            _jsonPlaceHolderExternalService = jsonPlaceHolderExternalService;
        }

        [HttpGet("exemplo1_sincrono")]
        public IActionResult Exemplo1Sincrono()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = _jsonPlaceHolderExternalService.GetAlbumsAsync().Result;
            var comments = _jsonPlaceHolderExternalService.GetCommentsAsync().Result;
            var photos = _jsonPlaceHolderExternalService.GetPhotosAsync().Result;
            var posts = _jsonPlaceHolderExternalService.GetPostsAsync().Result;
            var todos = _jsonPlaceHolderExternalService.GetTodosAsync().Result;
            var users = _jsonPlaceHolderExternalService.GetUsersAsync().Result;

            stopwatch.Stop();

            var modeloExemplo = new ModeloExemplo
            {
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Todos = todos,
                User = users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            return Ok(modeloExemplo);
        }

        [HttpGet("exemplo2_assincrono")]
        public async Task<IActionResult> Exemplo2AssincronoAsync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = await _jsonPlaceHolderExternalService.GetAlbumsAsync();
            var comments = await _jsonPlaceHolderExternalService.GetCommentsAsync();
            var photos = await _jsonPlaceHolderExternalService.GetPhotosAsync();
            var posts = await _jsonPlaceHolderExternalService.GetPostsAsync();
            var todos = await _jsonPlaceHolderExternalService.GetTodosAsync();
            var users = await _jsonPlaceHolderExternalService.GetUsersAsync();

            stopwatch.Stop();

            var modeloExemplo = new ModeloExemplo
            {
                Albums = albums,
                Comments = comments,
                Photos = photos,
                Posts = posts,
                Todos = todos,
                User = users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            return Ok(modeloExemplo);
        }

        [HttpGet("exemplo3_assincrono")]
        public async Task<IActionResult> Exemplo3AssincronoAsync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var albums = _jsonPlaceHolderExternalService.GetAlbumsAsync();
            var comments = _jsonPlaceHolderExternalService.GetCommentsAsync();
            var photos = _jsonPlaceHolderExternalService.GetPhotosAsync();
            var posts = _jsonPlaceHolderExternalService.GetPostsAsync();
            var todos = _jsonPlaceHolderExternalService.GetTodosAsync();
            var users = _jsonPlaceHolderExternalService.GetUsersAsync();

            var modeloExemplo = new ModeloExemplo
            {
                Albums = await albums,
                Comments = await comments,
                Photos = await photos,
                Posts = await posts,
                Todos = await todos,
                User = await users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            stopwatch.Stop();

            return Ok(modeloExemplo);
        }
    }
}
