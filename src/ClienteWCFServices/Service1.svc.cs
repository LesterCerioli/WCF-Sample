using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClienteWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Cliente GetData(int value)
        {
            var Cliente = new Cliente() { Id = 1, Name = "Lester", CPF = "12345678912" };
            return Cliente;
        }

        public List<Cliente> All()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Id = 1, Name = "Joao", CPF = "123456789"});
            return clientes;
            
        }

        public bool Save(string name, string cpf)
        {
            
            try
            {
                bool saved = new Cliente() { Name = name, CPF = cpf }.Save();
                return saved;
            }
            catch { return false; }

            
            //caso persistir com DB
            //new Cliente() { Id = 1, Name = "Jonas", CPF = cpf.save };
            
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool save(string name, string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
