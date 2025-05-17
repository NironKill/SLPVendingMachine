using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain
{
    public class Coin
    {
        [Key]
        public Guid Id { get; set; }
        public int Value { get; set; }
        public string Denomination { get; set; }
        public int Amount { get; set; }
    }
}
