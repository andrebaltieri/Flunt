using System;
using Flunt.Localization;
using Flunt.Samples.Handlers;
using Flunt.Samples.Handlers.Requests;
using Flunt.Samples.ValueObjects;

namespace Flunt.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractLocalization.IsEmailLocalizationErrorMessage = "deve ser um E-mail";

            var request = new CreateCustomerRequest("", "");
            var handler = new CustomerHandler();
            var response = handler.Handle(request);

            if (response == false)
            {
                foreach (var item in handler.Notifications)
                {
                    Console.WriteLine($"{item.Key} - {item.Message}");
                }
            }

            Console.ReadKey();

        }
    }
}
