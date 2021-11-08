using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Application.DTOs
{
    public class ContractResult
    {

        public ContractResult()
        {

        }

        public ContractResult(bool valid, string message, object data = null)
        {

        }

        public bool Valid { get; set; }
        public string Message { get; set; }
        public  object Data { get; set; }


        public static ContractResult InvalidContractResult(string message)
        {
            var contract = new ContractResult { 
                Message = message,
                Valid = false
            };
            
            return contract;
        }
        public static ContractResult InvalidContractResult(string message, object data)
        {
            var contract = new ContractResult
            {
                Message = message,
                Valid = false,
                Data = data
            };

            return contract;
        }
        public static ContractResult ValidContractResult(string message, object data)
        {
            var contract = new ContractResult
            {
                Message = message,
                Valid = false,
                Data = data
            };

            return contract;
        }
        public static ContractResult ValidContractResult(string message)
        {
            var contract = new ContractResult
            {
                Message = message,
                Valid = false
            };

            return contract;
        }
    }
}
