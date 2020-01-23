using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Работник с фиксированной зп.
/// </summary>
namespace Task_1_Worker
{
    class WorkerTaxFix : BaseWorker
    {
        public WorkerTaxFix(string nameSername, decimal tax, decimal hourse) : base(nameSername, tax, hourse) { }
        internal override decimal GetAverageMonthly() => Tax * DAYS_IN_MOUNTH;
        public override string ToString()
        {
            return $"Сотрудник {NameSername} имеет фиксированную среднемесячную зарплату в размере {GetAverageMonthly():0} со ставкой {Tax} руб. В день.";
        }
    }
}
