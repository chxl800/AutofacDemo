using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using System.Reflection;

namespace Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            ///* 第一注入*/
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Test>().As<ITest>().InstancePerLifetimeScope();

            //var container = builder.Build();
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var t = scope.Resolve<ITest>();
            //    t.ok();
            //    Console.ReadKey();
            //}

            ///* 第二注入*/
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Test>().As<ITest>();

            //var container = builder.Build();
            //var t= container.Resolve<ITest>();
            //t.ok();
            //Console.ReadKey();


            ///* 第三注入*/
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Test>();

            //var container = builder.Build();
            //var t = container.Resolve<Test>();
            //t.ok();
            //Console.ReadKey();

            /////* 第四注入*/
            //var builder = new ContainerBuilder();
            //builder.Register(c => new Test());

            //var container = builder.Build();
            //var t = container.Resolve<Test>();
            //t.ok();
            //Console.ReadKey();

            ///* 第五注入*/
            //var builder = new ContainerBuilder();
            //builder.RegisterInstance(new Test());

            //var container = builder.Build();
            //var t = container.Resolve<Test>();
            //t.ok();
            //Console.ReadKey();


            ///* 第五注入*/
            //var builder = new ContainerBuilder();
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(w=>w.Name.EndsWith("Test"));

            //var container = builder.Build();
            //var t = container.Resolve<Test>();
            //t.ok();
            //Console.ReadKey();

            List<string> list = new List<string> { "1", "12" };
            var d = list;
        }
    }
}
