using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree.UI;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Data;

namespace TreeGeneric.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AutoFac = IoC (Inversion-of-Control) Provider'ı dır. Bununla dependency injection işini kolaylaştırır.

            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>().SingleInstance();

            /*repositories Yöntem 1
            builder.RegisterType<Repository<TreeGeneric.Model.Region>>().As<IRepository<TreeGeneric.Model.Region>>();
            */

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            //services
            builder.RegisterType<RegionService>().As<IRegionService>();
            builder.RegisterType<PlantingService>().As<IPlantingService>();
            builder.RegisterType<DonationService>().As<IDonationService>();
            builder.RegisterType<TreeTypeService>().As<ITreeTypeService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<PostService>().As<IPostService>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmSplash(scope));
            }
        }
    }
}
