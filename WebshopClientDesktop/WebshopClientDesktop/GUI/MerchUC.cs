using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebshopClientDesktop.ControlLayer;
using WebshopClientDesktop.Logging;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.GUI
{
    public partial class MerchUC : UserControl
    {
        readonly ProductControl _productControl;
        
        public MerchUC()
        {
            InitializeComponent();

            _productControl = new ProductControl();
        }

        private async void BtnGetMerchProducts_Click(object sender, EventArgs e)
        {
            Logger.LogInfo("Button getMerch clicked");
            string processText = "OK";
            List<Product> fetchedProducts = await _productControl.GetAllProductsByMerchType();
            if (fetchedProducts != null)
            {
                if (fetchedProducts.Count >= 1)
                {
                    processText = "Ok";
                }
                else
                {
                    processText = "No merch products found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }
            lblProcessText.Text = processText;
            listBoxMerchProducts.DataSource = fetchedProducts;
        }
    }
}
