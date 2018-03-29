using JSObjectToWebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using static JSObjectToWebApi.Models.Persons;

namespace JSObjectToWebApi.Controllers
{
    public class PersonController : ApiController
    {
        static readonly PersonsRepository repository = new PersonsRepository();
        public Persons PostProduct(Persons item)
        {
            return repository.Add(item);
        }
    }
}
