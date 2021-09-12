using Refit;
using System;
using System.Threading.Tasks;

namespace RefitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = RestService.For<IApiService>("https://viacep.com.br/");

            Console.WriteLine("Enter the zip code...");
            var cep = Console.ReadLine();

            Console.WriteLine($"\nSearching for information about the zip code: {cep}...");
            var response = await service.GetAsync(cep);

            Console.WriteLine($"\nCep: {response.Cep}" +
                              $"\nLogradouro: {response.Logradouro}" +
                              $"\nComplemento: {response.Complemento}" +
                              $"\nBairro: {response.Bairro}" +
                              $"\nLocalidade: {response.Localidade}" +
                              $"\nUF: {response.UF}" +
                              $"\nIBGE: {response.IBGE}" +
                              $"\nGIA: {response.GIA}" +
                              $"\nDDD: {response.DDD}" +
                              $"\nSIAFI: {response.SIAFI}");

            Console.ReadKey();
        }
    }
}
