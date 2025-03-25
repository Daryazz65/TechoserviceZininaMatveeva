using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TechoserviceZininaMatveeva.Model;

namespace TechoserviceZininaMatveeva
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ZininaMatveevaDemo1Entities _context = new ZininaMatveevaDemo1Entities();

        public static EmployeeAccount currentAccount;
    }
}
