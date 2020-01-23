using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_Worker
{
    /// <summary>
    /// * Создать класс, содержащий массив сотрудников, и реализовать возможность вывода данных с использованием foreach.
    /// </summary>
    class Workers : IEnumerable
    {
        BaseWorker[] _workers;
        Random _r = new Random();
        string[] _workerNames = new string[] { "Вася", "Петя", "Лена", "Гриша", "Саша" };
        const int _MAX_HOUR = 8;
        internal void CreateWorkers()
        {
            _workers = new BaseWorker[_workerNames.Length];
            for (int i = 0; i < _workers.Length; i++)
            {
                if (_r.Next(0, 2) == 0)
                    _workers[i] = new WorkerTaxHour(_workerNames[i], _r.Next(50, 201), _MAX_HOUR);
                else
                    _workers[i] = new WorkerTaxFix(_workerNames[i], _r.Next(500, 1201), _MAX_HOUR);
            }
        }
        internal void LoadWorkers(ListBox listWorkers)
        {
            if (_workers != null)
            {
                listWorkers.Items.Clear();
                CreateWorkers();
                foreach (var w in _workers)
                {
                  listWorkers.Items.Add(w.ToString());
                }
            }
        }
        internal void SortSalary(ListBox listWorkers)
        {
            if (listWorkers.Items.Count != 0) listWorkers.Items.Clear();
            if (_workers != null) 
            {
                Array.Sort(_workers);
                foreach(var w in _workers)
                {
                    listWorkers.Items.Add(w.ToString());
                }
            }
        }
        /// <summary>
        /// реализовать возможность вывода данных с использованием foreach.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return _workers.GetEnumerator();
        }
    }
}
