using AvicennaDispensing.Models;

namespace AvicennaDispensing.ViewModels
{
    public class ServiceUnitTransactionEntryViewModel
    {
        public class BinItem
        {
            public MultiBatchBalanceBin MultiBatchBalanceBin { get; set; }
            public string ItemName { get; set; } = null!;
        }
        public class RegistartionDetail
        {
            public Registration? Registration { get; set; }
            public Patient? Patient { get; set; }
            public string? ParamedicName { get; set; }
        }
    }
}
