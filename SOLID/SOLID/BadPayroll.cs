using System;

namespace SOLID
{
    public enum EmployeeType
    {
        Commissioned,
        Hourley,
        Salaried
    }

    public enum PayDelivery
    {
        MailCheck,
        DirectDeposit
    }

    public class BadPayroll
    {
        public EmployeeType Type;

        public BadPayroll(EmployeeType type)
        {
            Type = type;
        }

        public decimal CalculatePay()
        {
            var pay = 0m;
            switch (Type)
            {
                case EmployeeType.Commissioned:
                //fall through                    
                case EmployeeType.Hourley:
                    pay = 200m;
                    break;
                case EmployeeType.Salaried:
                    pay = 500;
                    break;
                default:
                    pay = 0m;
                    break;
            }

            return pay;
        }

        public bool IsPayDay(DateTime dt)
        {
            var isPayDay = true;
            switch (Type)
            {
                case EmployeeType.Commissioned:
                //fall through            
                case EmployeeType.Hourley:
                //fall through
                case EmployeeType.Salaried:
                    isPayDay = dt.DayOfWeek.Equals(DayOfWeek.Friday);
                    break;
                default:
                    isPayDay = false;
                    break;
            }

            return isPayDay;
        }

        public PayDelivery GetPayDelivery()
        {
            switch (Type)
            {
                case EmployeeType.Commissioned:
                    return PayDelivery.MailCheck;
                case EmployeeType.Hourley:
                    return PayDelivery.DirectDeposit;
                case EmployeeType.Salaried:
                    return PayDelivery.DirectDeposit;
                default:
                    return PayDelivery.DirectDeposit;
            }
        }
    }
}