using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace NaruciBa.Database
{
    public class Data
    {
        public static void Seed(NaruciBaContext context)
        {
            context.Database.Migrate();
        }
    }
}
