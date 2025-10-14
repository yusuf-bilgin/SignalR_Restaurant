using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    /// <summary>
    /// Kasa tablosu için entity sınıfı
    /// Para kasasını ve işlemlerini temsil eder
    /// </summary>
    public class CashRegister
    {
        public int CashRegisterId { get; set; }
        public decimal TotalAmount { get; set; } // Kasa bakiyesi
    }
}
