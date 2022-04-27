using ProgramacaoAssincrona.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona.ExternalServices
{
    public interface IJsonPlaceHolderExternalService
    {
        Task<IEnumerable<Post>> GetPostsAsync();
        Task<IEnumerable<Comment>> GetCommentsAsync();
        Task<IEnumerable<Album>> GetAlbumsAsync();
        Task<IEnumerable<Photo>> GetPhotosAsync();
        Task<IEnumerable<Todo>> GetTodosAsync();
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
