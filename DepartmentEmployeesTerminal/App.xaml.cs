﻿using DepartmentEmployeesTerminal.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DepartmentEmployeesTerminal
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static GuardianEntities DB = new GuardianEntities();
        public static MainWindow MainWindowInstance = new MainWindow();
    }
}
