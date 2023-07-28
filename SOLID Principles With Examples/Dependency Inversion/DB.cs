using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Dependency_Inversion
{
    internal interface IDatabase
    {
        public void Insert();
        public void Update();
        public void Delete();
    }

    class SQL : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("SQL Deletion");
        }

        public void Insert()
        {
            Console.WriteLine("SQL Insertion");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updation");
        }
    }


    class MongoDB : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("MongoDB Deletion");
        }

        public void Insert()
        {
            Console.WriteLine("MongoDB Insertion");
        }

        public void Update()
        {
            Console.WriteLine("MongoDB Updation");
        }
    }



}
