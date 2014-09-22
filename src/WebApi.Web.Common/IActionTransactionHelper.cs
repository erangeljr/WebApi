using System.Web.Http.Filters;

namespace WebApi.Web.Common
{
    public interface IActionTransactionHelper
    {
        void BeginTransaction();
        void EndTransaction(HttpActionExecutedContext filterContext);
        void CloseSession();
    }
}
