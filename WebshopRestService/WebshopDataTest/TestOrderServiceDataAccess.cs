using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopData.DatabaseLayer;
using WebshopDataTest;
using WebshopRestService.BusinessLogicLayer;
using Xunit.Abstractions;

namespace WebshopDataTest
{
    public class TestOrderServiceDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;

        readonly private IOrderAccess _orderAccess;
        readonly private IOrderData _orderServiceAccess;

        readonly private IOrderLineAccess _orderLineAccess;
        readonly private IOrderLineData _orderLineServiceAccess;

        readonly private IPersonAccess _personAccess;
        readonly private IPersonData _personServiceAccess;

        readonly private IProductAccess _productAccess;
        readonly private IProductData _productServiceAccess;

        public TestOrderServiceDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            IConfiguration inConfig = TestConfigHelper.GetIConfigurationRoot();

            _orderAccess = new OrderDatabaseAccess(inConfig);
            _orderServiceAccess = new OrderDataControl(_orderAccess);

            _orderLineAccess = new OrderLineDatabaseAccess(inConfig);
            _orderLineServiceAccess = new OrderLineDataControl(_orderLineAccess);

            _personAccess = new PersonDatabaseAccess(inConfig);
            _personServiceAccess = new PersonDataControl(_personAccess);

            _productAccess = new ProductDatabaseAccess(inConfig);
            _productServiceAccess = new ProductDataControl(_productAccess);

        }
    }
}
