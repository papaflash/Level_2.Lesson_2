using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// базовый класс от которого наследуются два класса работников
/// </summary>
namespace Task_1_Worker
{
    abstract class BaseWorker: IComparable
    {
        protected const decimal DAYS_IN_MOUNTH = 20.8m;
        protected string NameSername { set; get; }
        protected decimal Tax { set; get; }
        protected decimal Hourse { set; get; }
        protected BaseWorker(string nameSername, decimal tax, decimal hourse)
        {
            NameSername = nameSername;
            Tax = tax;
            Hourse = hourse;
        }
       internal abstract decimal GetAverageMonthly();
        /// <summary>
        /// Реализовать интерфейсы для возможности сортировки массива, используя Array.Sort();
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            BaseWorker bw = obj as BaseWorker;
            decimal _salaryThis = this.GetAverageMonthly();
            decimal _salaryOther = bw.GetAverageMonthly();
            if (_salaryThis > _salaryOther)
                return 1;
            else if (_salaryThis == _salaryOther)
                return 0;
            else
                return -1;
        }
    }
}
