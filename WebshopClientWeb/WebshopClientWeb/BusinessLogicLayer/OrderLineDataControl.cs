using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net;
using WebshopClientWeb.Model;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class OrderLineDataControl
    {
        readonly IOrderLineServiceAccess _OrderLineAccess;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public OrderLineDataControl()
        {
            _OrderLineAccess = new OrderLineServiceAccess();
        }
    }
}

