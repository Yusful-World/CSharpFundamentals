using MoshInt_Composition;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshInt_Composition
{
}

namespace MoshInt_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //COMPOSITION
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();


            //INHERITANCE
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();
        }
    }
}
