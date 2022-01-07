using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationOOP
{
    public enum PaymentSchedule { Annual, Biannual, Monthly };
    class Member
    {
        public DateTime JoinDate;
        public Decimal Fee;
        public PaymentSchedule PaymentType;
        public String Name;
        public PaymentSchedule paymentSchedule { get; set; }
        private DateTime renewalDate;

        /*    private DateTime daysToRenewal;
            public DateTime DaysToRenewal
            {
                get
                {
                    daysToRenewal = renewalDate - DateTime.Now;
                    return daysToRenewal;
                }
            }

        */
        public DateTime RenewalDate
        {
            get
            {
                renewalDate = JoinDate.AddMonths(1);
                return renewalDate;
            }
        }
        public decimal CalculateFees(decimal fee)
        {
            if (PaymentType == PaymentSchedule.Monthly)
                fee = Fee / 12;
            else if (PaymentType == PaymentSchedule.Biannual)
                fee = Fee / 2;
            else if (PaymentType == PaymentSchedule.Annual)
                fee = Fee / 1;

            return fee;
        }
        public override string ToString()
        {
            return $"{Name}";
       }
    }
}
