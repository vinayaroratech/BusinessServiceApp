using BusinessServiceApp.Application.Implementation;

namespace BusinessServiceApp.Application.Services
{
    abstract class BusinessFactory
    {
        public abstract Business GetBusiness();
    }
}
