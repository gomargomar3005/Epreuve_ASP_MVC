using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Epreuve_ASP_MVC.Handlers
{
    public class SessionManager
    {
            private readonly ISession _session;

            public SessionManager(IHttpContextAccessor accessor)
            {
                _session = accessor.HttpContext.Session;
            }

            public List<CartItem> ShoppingCart
            {
                get
                {
                    string data = _session.GetString(nameof(ShoppingCart));
                    if (data is null) return new List<CartItem>();
                    return JsonSerializer.Deserialize<List<CartItem>>(data);
                }
                set
                {
                    if (value is null)
                        _session.Remove(nameof(ShoppingCart));
                    else
                        _session.SetString(nameof(ShoppingCart), JsonSerializer.Serialize(value));
                }
            }
        }

        public class CartItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }

