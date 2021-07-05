using System;
using System.Threading.Tasks;

namespace ncwsapp.Services
{
    public interface IHttpService
    {
        Task<string> Ping(Uri uri);
    }
}