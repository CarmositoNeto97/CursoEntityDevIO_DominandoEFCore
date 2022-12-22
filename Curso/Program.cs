using System;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            EnsureCreatedAnDeleted();
        }

        static void EnsureCreatedAnDeleted()
        {
            using var db = new Curso.Data.ApplicationContext();
            db.Database.EnsureCreated();
        }
    }
}
