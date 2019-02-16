using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\Adam\\source\\repos\\ObjectOrientedRPS\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
