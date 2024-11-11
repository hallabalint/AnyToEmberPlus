using System.Reflection;

namespace AnyToEmberPlus
{
    internal static class Program
    {
        public static List<Provider> Providers;
        public static EmberPlus _ember;
        public static List<Type> LoadedTypes = new List<Type>();
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadModules();
            Providers = new List<Provider>();
            _ember = new EmberPlus(9000);
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        public static void AddModule(Type type, string name, string nodeName)
        {
            var node = _ember.getNewEmberNode(nodeName);
            Provider provider = (Provider)Activator.CreateInstance(type, node, name);
            Providers.Add(provider);
            
        }
        static void LoadModules()
        {
            string modulesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "modules");
            if (Directory.Exists(modulesPath))
            {
                foreach (string dll in Directory.GetFiles(modulesPath, "*.dll"))
                {
                    Assembly assembly = Assembly.LoadFrom(dll);
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (typeof(Provider).IsAssignableFrom(type) && !type.IsAbstract)
                        {
                            LoadedTypes.Add(type);
                        }
                    }
                }
            }
        }
    }
}