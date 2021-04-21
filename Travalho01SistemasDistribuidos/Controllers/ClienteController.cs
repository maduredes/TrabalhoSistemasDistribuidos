using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Travalho01SistemasDistribuidos.Models;

namespace Travalho01SistemasDistribuidos.Controllers
{
    [EnableCors(origins: "https://localhost:44360",headers:"*",methods:"*")]

    //Para conseguir acessar a documentação no swagger, 
    //precisa executar o programa e quando abrir colocar:https://localhost:44360/swagger/ui/index
    public class ClienteController : ApiController
    {
        private static List<Clients> listaClientes = new List<Clients>();

        public List<Clients> Get()
        {

            return listaClientes.ToList();
        }
        public Clients Get(int id)
        {
            return listaClientes.Where(w => w.Id==id).FirstOrDefault();
        }

        public void Post(string nome,string email,int idade)
        {

            if (!String.IsNullOrWhiteSpace(nome))
            {
                if (listaClientes.Count() != 0)
                {
                    var passaId = listaClientes.Count + 1;
                    Clients client = new Clients();
                    client.Id = passaId;
                    client.Nome = nome;
                    client.Email = email;
                    client.Idade = idade;

                    listaClientes.Add(client);


                }
                else
                {
                    Clients client = new Clients();
                    client.Id = 1;
                    client.Nome = nome;
                    client.Email = email;
                    client.Idade = idade;

                    listaClientes.Add(client);
                }
            }
           
        }
        [HttpDelete]
        public void Delete(int Id)
        {
            listaClientes.RemoveAt(listaClientes.IndexOf(listaClientes.First(w=>w.Id.Equals(Id))));
            Console.Write("Deletado com sucesso!");
            
        }
        public void Put(int Id,string nome,string email,int idade)
        {
            var lista=listaClientes.Where(w => w.Id == Id).ToList();
            foreach(var item in lista)
            {
                item.Nome = nome;
                item.Email = email;
                item.Idade = idade;
                
            }
        }
    }
}
