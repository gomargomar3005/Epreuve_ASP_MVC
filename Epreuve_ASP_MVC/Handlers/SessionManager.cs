//using System.Text.Json;
//using Microsoft.AspNetCore.Http;
//using System.Collections.Generic;
//using System.Linq;

//namespace Epreuve_ASP_MVC.Handlers
//{
//    public class SessionManager
//    {
//            private readonly ISession _session;

//            public SessionManager(IHttpContextAccessor accessor)
//            {
//                _session = accessor.HttpContext.Session;
//            }

//            public List<Panier> Commande
//            {
//                get
//                {
//                    string data = _session.GetString(nameof(Commande));
//                    if (data is null) return new List<Panier>();
//                    return JsonSerializer.Deserialize<List<Panier>>(data);
//                }
//                set
//                {
//                    if (value is null)
//                        _session.Remove(nameof(Commande));
//                    else
//                        _session.SetString(nameof(Commande), JsonSerializer.Serialize(value));
//                }
//            }
//        }

//        public class Panier
//        {
//            public int Id_Panier { get; set; }
//            public int Quantite { get; set; }
//            public int Id_Produit { get; set; }
//            public int Id_Commande { get; set; }
//        }
//    }

