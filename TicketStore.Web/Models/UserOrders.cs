using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketStore.Domain.DbContext;

namespace TicketStore.Web.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(VoyageData voyage, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g._voyage.VoyageID == voyage.VoyageID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    _voyage = voyage,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(VoyageData voyage)
        {
            lineCollection.RemoveAll(l => l._voyage.VoyageID == voyage.VoyageID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e._voyage.TicketCoast * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public VoyageData _voyage { get; set; }
        public int Quantity { get; set; }
    }
}
  