using MediatR;

namespace CleanTemplate.Application.Common
{
    public class BaseCqrsRequest<T> : IRequest<T>
    {
        protected BaseCqrsRequest(string appUser)
        {
            AppUser = appUser;
        }

        public string AppUser { get; }
    }
}
