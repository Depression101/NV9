using NV_Prezentace.Template;
using System;
using NV_Prezentace.Commands;
using System.Collections.Generic;
using NV_Prezentace.Iterátor;
using NV_Prezentace.State;
using NV_Prezentace.FacadeFolder;
using NV_Prezentace.AdapterFolder;
using NV_Prezentace.CompositeFolder;
using NV_Prezentace.Proxy;

namespace NV_Prezentace
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Command
            CommandExample example = new CommandExample();
            example.Test();
            #endregion
            #region Iterator
            int[] array = { 1, 2, 3 };
            SimpleIterator<int> iterator = new ForwardArrayIterator<int>(array);
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            #endregion
            #region State
            StateExample state = new StateExample();
            state.Test();
            #endregion
            #region Template
            TemplateExample.TestChild();
            TemplateExample.TestWorker();
            #endregion
            #region Facade
            FacadeExample facade = new FacadeExample();
            facade.Test();
            #endregion
            #region Adapter
            AdapterExample adapter = new AdapterExample();
            adapter.Test();
            #endregion
            #region Composite
            CompositeExample composite = new CompositeExample();
            composite.Test();
            #endregion
        }
    }
    public class TemplateExample
    {
        public static void TestWorker()
        {
            Person Worker = new Worker();
            Worker.PrintDailyRoutine();
        }
        public static void TestChild()
        {
            Person child = new Child();
            child.PrintDailyRoutine();
        }
    }
    public class CommandExample
    {
        public void Test()
        {
            System.Collections.Generic.List<Command> commands = new System.Collections.Generic.List<Command>();
            commands.Add(new PrintCommand("First line."));
            commands.Add(new NewLineCommand());
            commands.Add(new PrintCommand("Second line."));
            commands.Add(new NewLineCommand());
            commands.Add(new PrintCommand("Third line."));
            foreach(Command command in commands)
            {
                command.Execute();
            }
        }
    }
    public class StateExample
    {
        public void Test()
        {
            Context context = new Context();
            context.ChangeMood();
            context.Express();
        }
    }
    public class FacadeExample
    {
        public void Test()
        {
            Facade facade = new Facade();
            Console.WriteLine(facade.Negative(-5));
            Console.WriteLine(facade.Mean(10,20));
            Console.WriteLine(facade.Square(5));
        }
    }
    public class AdapterExample
    {
        public void Test()
        {
            Target adapter = new Adapter();
            adapter.NewRequest();
        }
    }
    public class CompositeExample
    {
        public void Test()
        {
            Composite composite = new Composite();
            composite.AddComponent(new Leaf());
            composite.DoSomething();
        }
    }
}
