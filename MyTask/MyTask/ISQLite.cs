using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTask
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
