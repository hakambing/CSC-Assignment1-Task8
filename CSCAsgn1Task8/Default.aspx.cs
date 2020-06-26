using Clarifai.API;
using Clarifai.DTOs.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAsgn1Task8
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnUpload_Click(object sender,EventArgs e)
        //{
        //    {
        //        //choosing file to upload
        //        System.IO.Stream stream = FileUpload1.PostedFile.InputStream;
        //        System.IO.BinaryReader br = new System.IO.BinaryReader(stream);
        //        Byte[] bytes = br.ReadBytes((Int32)stream.Length);
        //        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
        //        Image1.ImageUrl = "data:image/jpeg;base64," + base64String;
        //        Image1.Visible = true;
        //    }
        //}
        public static async Task UploadImage()
        {
            var client = new ClarifaiClient("8499201759f44bae87d8ba3ea2121d2b");

            await client.AddInputs(
                new ClarifaiURLImage("https://i.imgur.com/IPsBWaA.jpg"))
                .ExecuteAsync();
        }

        public static async Task CreateModel()
        {
            var client = new ClarifaiClient("8499201759f44bae87d8ba3ea2121d2b");

            await client.CreateModel("petsID")
                .ExecuteAsync();
        }
    }
}