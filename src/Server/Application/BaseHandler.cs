using System.Threading.Tasks;
using KakegoeBlazor.Server.Infrastructure;

namespace KakegoeBlazor.Server.Application
{
    public abstract class BaseHandler<T, U>
    {
        protected KakegoeBlazorContext Context { get; private set; }

        public BaseHandler(KakegoeBlazorContext context)
        {
            Context = context;
        }

        public abstract Task<U> HandleAsync(T query);
    }
}
