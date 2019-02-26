using Newtonsoft.Json;
using RestSharp;
using Sample.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://localhost:50805/api/customer/ListAll");

            var request = new RestRequest(Method.POST);

            IRestResponse response = client.Execute(request);
            String content = response.Content;

            List<CustomerModel> model = JsonConvert.DeserializeObject<List<CustomerModel>>(content);

            foreach(CustomerModel customerModel in model)
                Console.WriteLine("Your customer name is: " + customerModel.Name);

            Console.ReadLine();
        }
    }
}
