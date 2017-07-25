using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace AliexpressAPIResolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        AliexpressProduct.Rootobject products;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            products = serialized_data_download<AliexpressProduct.Rootobject>(@"https://gw.api.alibaba.com/openapi/param2/2/portals.open/api.listHotProducts/[Appkey]?localCurrency=TR&language=tr");
            for (int i = 0; i < products.result.totalResults-1; i++)
            {
                listBox1.Items.Add("Ürün Adı :" + products.result.products[i].productTitle + " || Fiyat : " + products.result.products[i].salePrice + "  || Ürün Linki :" + products.result.products[i].productUrl + "  || Kalan Adet :" + products.result.products[i].volume);
            }
        }

        private static T serialized_data_download<T>(string url) where T : new ()
        {
            using (var webclient = new WebClient())
            {
                var json_data = "";
                try
                {
                    json_data = webclient.DownloadString(url);
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }               
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AliexpressPromotionProduct.Rootobject products = serialized_data_download<AliexpressPromotionProduct.Rootobject>(@"http://gw.api.alibaba.com/openapi/param2/2/portals.open/api.listPromotionProduct/[Appkey]?fields=productUrl,imageUrl,localPrice,validTime,productTitle&pageSize=20&highQualityItems=yes&keywords=keyboard");
            for (int i = 0; i < products.result.totalResults - 1; i++)
            {
                listBox1.Items.Add("Ürün Adı :" + products.result.products[i].productTitle + " || Fiyat : " + products.result.products[i].salePrice + "  || Ürün Linki :" + products.result.products[i].productUrl + "  || Kalan Adet :" + products.result.products[i].volume);
            }
        }
    }


}
