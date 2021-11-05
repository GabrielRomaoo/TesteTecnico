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
        public object Data { get; set; }


        public ContractResult InvalidContractResult(string message)
        {
            var contract = new ContractResult();
            Message = message;
            Valid = false;
            return contract;
        }
        public ContractResult InvalidContractResult(string message, object data)
        {
            var contract = new ContractResult();
            Message = message;
            Data = data;
            Valid = false;
            return contract;
        }
        public ContractResult ValidContractResult(string message, object data)
        {
            var contract = new ContractResult();
            Message = message;
            Data = data;
            Valid = true;
            return contract;
        }
        public ContractResult ValidContractResult(string message)
        {
            var contract = new ContractResult();
            Message = message;
            Valid = true;
            return contract;
        }
    }
}
