using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Работник с почасовой ставкой
/// </summary>
namespace Task_1_Worker
{
    class WorkerTaxHour: BaseWorker
    {
        public WorkerTaxHour(string nameSername, decimal tax, decimal hourse) : base(nameSername, tax, hourse) { }
        internal override decimal GetAverageMonthly() => DAYS_IN_MOUNTH * Hourse * Tax;
        public override string ToString()
        {
            return $"Сотрудник {NameSername} имеет по часовую среднемесячную зарплату в размере {GetAverageMonthly():0} со ставкой {Tax} руб. в час";
        }
    }
}
