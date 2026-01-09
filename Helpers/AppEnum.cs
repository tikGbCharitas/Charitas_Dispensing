namespace AvicennaDispensing.Helpers
{
    public class AppEnum
    {
        public enum DataMode
        {
            View = 0, 
            Edit = 1
        }
        public enum Status
        {
            PENDING,
            APPROVE,
            VOID,
            NEW,
            UPDATE,
            DISPENSED,
            RESERVED
        }

        public enum TransactionCode
        {
            StockOpname = 075
        }

        public enum Theme
        {
            light,
            dark
        }
        public enum Language
        {
            en,
            id, 
            auto
        }
    }
}
